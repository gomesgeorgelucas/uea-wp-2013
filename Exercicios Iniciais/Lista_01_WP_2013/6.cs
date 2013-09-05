using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_WP_2013
{   
    /// <summary>
    /// This class implements a virtual TV. The functionalities available are volume and channel control.
    /// </summary>
    class Tevelisor
    {
        //Instance varibles, getters and setters.
        private int _minChannel;

        public int minChannel
        {
            get { return _minChannel; }
            set { _minChannel = value; }
        }

        private int _minVolume;

        public int minVolume
        {
            get { return _minVolume; }
            set { _minVolume = value; }
        }
        
        private int _maxVolume;

        public int maxVolume
        {
            get { return _maxVolume; }
            set { _maxVolume = value; }
        }

        private int _maxChannel;

        public int maxChannel
        {
            get { return _maxChannel; }
            set { _maxChannel = value; }
        }

        private int _channel;

        public int channel
        {
            get { return _channel; }
            set { _channel = value; }
        }

        private int _volume;

        public int volume
        {
            get { return _volume; }
            set { _volume = value; }
        }       
        
        /// <summary>
        /// Construtor da classe tevelisão.
        /// Este construtor precisa dos limites de volume e canal aceitos pela TV.
        /// </summary>
        /// <param name="minChannel"> Limite inferior do canal.</param>
        /// <param name="minVolume">Limite inferior do volume.</param>
        /// <param name="maxChannel">Limite superior do canal. </param>
        /// <param name="maxVolume">Limite superior do volume.</param>
        public Tevelisor(int minChannel, int minVolume, int maxChannel, int maxVolume )
        {
            this.minChannel = maxChannel;
            this.minVolume = minVolume;
            this.maxChannel = maxChannel;
            this.maxVolume = maxVolume;
            this.channel = 2;
            this.volume = 50;
        }
        
        /// <summary>
        /// Main method for the Tevelisor class.
        /// </summary>
        /// <param name="args">No parameters necessary.</param>
        static void Main(string[] args)
        {
            Tevelisor myTv = new Tevelisor(0,0,99,100);

            string indexS = "";
            int indexI = 0;
             
            do
            {
                System.Console.WriteLine("Welcome to your TV.");
                System.Console.WriteLine("Increase channel (" + myTv.channel + ") - 0");
                System.Console.WriteLine("Decrease channel (" + myTv.channel + ") - 1");
                System.Console.WriteLine("Increase volume (" + myTv.volume + ") - 2");                
                System.Console.WriteLine("Decrease volume (" + myTv.volume + ") - 3");
                System.Console.WriteLine("Turn off - 4");
                System.Console.Write("Enter option!");
               
                indexS = System.Console.ReadLine();
                indexI = int.Parse(indexS);
                

                switch (indexI)
                {
                    case 0: //Channel Increase
                        if (myTv.channel < myTv.maxChannel)
                            myTv.channel++;
                        else
                            myTv.channel = myTv.minChannel;                        
                        break;

                    case 1: //Channel Decrease
                        if (myTv.channel > myTv.minChannel)
                            myTv.channel--;
                        else
                            myTv.channel = myTv.maxChannel;                        
                        break;                       

                    case 2: //Volume Increase
                        if (myTv.volume < myTv.maxVolume)
                            myTv.volume++;
                        else
                            System.Console.WriteLine("Already at maximum volume!");
                        break;

                    case 3: //Volume Decrease
                        if (myTv.volume > myTv.minVolume)
                            myTv.volume--;
                        else
                            System.Console.WriteLine("Already at minimum volume!");
                        break; 

                    case 4: //Exit                       
                        System.Console.WriteLine("Bye!");
                        return;

                    default:
                        System.Console.WriteLine("Option unavailable!");
                        break;
                }

            } while (indexI != 4);
        }        
    }
}
