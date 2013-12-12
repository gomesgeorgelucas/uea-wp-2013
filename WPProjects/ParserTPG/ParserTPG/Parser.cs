using System;
using System.Collections.Generic;

namespace TinyPG
{
    #region Parser

    public partial class Parser 
    {
        private Scanner scanner;
        private ParseTree tree;
        
        public Parser(Scanner scanner)
        {
            this.scanner = scanner;
        }

        public ParseTree Parse(string input)
        {
            tree = new ParseTree();
            return Parse(input, tree);
        }

        public ParseTree Parse(string input, ParseTree tree)
        {
            scanner.Init(input);

            this.tree = tree;
            ParseStart(tree);
            tree.Skipped = scanner.Skipped;

            return tree;
        }

        private void ParseStart(ParseNode parent)
        {
            Token tok;
            ParseNode n;
            ParseNode node = parent.CreateNode(scanner.GetToken(TokenType.Start), "Start");
            parent.Nodes.Add(node);


            
            tok = scanner.LookAhead(TokenType.NUMBER, TokenType.BROPEN);
            if (tok.Type == TokenType.NUMBER
                || tok.Type == TokenType.BROPEN)
            {
                ParseAddExpr(node);
            }

            
            tok = scanner.Scan(TokenType.EOF);
            n = node.CreateNode(tok, tok.ToString() );
            node.Token.UpdateRange(tok);
            node.Nodes.Add(n);
            if (tok.Type != TokenType.EOF) {
                tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found. Expected " + TokenType.EOF.ToString(), 0x1001, 0, tok.StartPos, tok.StartPos, tok.Length));
                return;
            }

            parent.Token.UpdateRange(node.Token);
        }

        private void ParseAddExpr(ParseNode parent)
        {
            Token tok;
            ParseNode n;
            ParseNode node = parent.CreateNode(scanner.GetToken(TokenType.AddExpr), "AddExpr");
            parent.Nodes.Add(node);


            
            ParseMultExpr(node);

            
            tok = scanner.LookAhead(TokenType.PLUSMINUS);
            while (tok.Type == TokenType.PLUSMINUS)
            {

                
                tok = scanner.Scan(TokenType.PLUSMINUS);
                n = node.CreateNode(tok, tok.ToString() );
                node.Token.UpdateRange(tok);
                node.Nodes.Add(n);
                if (tok.Type != TokenType.PLUSMINUS) {
                    tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found. Expected " + TokenType.PLUSMINUS.ToString(), 0x1001, 0, tok.StartPos, tok.StartPos, tok.Length));
                    return;
                }

                
                ParseMultExpr(node);
            tok = scanner.LookAhead(TokenType.PLUSMINUS);
            }

            parent.Token.UpdateRange(node.Token);
        }

        private void ParseMultExpr(ParseNode parent)
        {
            Token tok;
            ParseNode n;
            ParseNode node = parent.CreateNode(scanner.GetToken(TokenType.MultExpr), "MultExpr");
            parent.Nodes.Add(node);


            
            ParseAtom(node);

            
            tok = scanner.LookAhead(TokenType.MULTDIV);
            while (tok.Type == TokenType.MULTDIV)
            {

                
                tok = scanner.Scan(TokenType.MULTDIV);
                n = node.CreateNode(tok, tok.ToString() );
                node.Token.UpdateRange(tok);
                node.Nodes.Add(n);
                if (tok.Type != TokenType.MULTDIV) {
                    tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found. Expected " + TokenType.MULTDIV.ToString(), 0x1001, 0, tok.StartPos, tok.StartPos, tok.Length));
                    return;
                }

                
                ParseAtom(node);
            tok = scanner.LookAhead(TokenType.MULTDIV);
            }

            parent.Token.UpdateRange(node.Token);
        }

        private void ParseAtom(ParseNode parent)
        {
            Token tok;
            ParseNode n;
            ParseNode node = parent.CreateNode(scanner.GetToken(TokenType.Atom), "Atom");
            parent.Nodes.Add(node);

            tok = scanner.LookAhead(TokenType.NUMBER, TokenType.BROPEN);
            switch (tok.Type)
            {
                case TokenType.NUMBER:
                    tok = scanner.Scan(TokenType.NUMBER);
                    n = node.CreateNode(tok, tok.ToString() );
                    node.Token.UpdateRange(tok);
                    node.Nodes.Add(n);
                    if (tok.Type != TokenType.NUMBER) {
                        tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found. Expected " + TokenType.NUMBER.ToString(), 0x1001, 0, tok.StartPos, tok.StartPos, tok.Length));
                        return;
                    }
                    break;
                case TokenType.BROPEN:

                    
                    tok = scanner.Scan(TokenType.BROPEN);
                    n = node.CreateNode(tok, tok.ToString() );
                    node.Token.UpdateRange(tok);
                    node.Nodes.Add(n);
                    if (tok.Type != TokenType.BROPEN) {
                        tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found. Expected " + TokenType.BROPEN.ToString(), 0x1001, 0, tok.StartPos, tok.StartPos, tok.Length));
                        return;
                    }

                    
                    ParseAddExpr(node);

                    
                    tok = scanner.Scan(TokenType.BRCLOSE);
                    n = node.CreateNode(tok, tok.ToString() );
                    node.Token.UpdateRange(tok);
                    node.Nodes.Add(n);
                    if (tok.Type != TokenType.BRCLOSE) {
                        tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found. Expected " + TokenType.BRCLOSE.ToString(), 0x1001, 0, tok.StartPos, tok.StartPos, tok.Length));
                        return;
                    }
                    break;
                default:
                    tree.Errors.Add(new ParseError("Unexpected token '" + tok.Text.Replace("\n", "") + "' found.", 0x0002, 0, tok.StartPos, tok.StartPos, tok.Length));
                    break;
            }

            parent.Token.UpdateRange(node.Token);
        }


    }

    #endregion Parser
}
