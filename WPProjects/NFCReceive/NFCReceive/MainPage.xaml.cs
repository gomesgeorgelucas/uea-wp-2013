using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NFCReceive.Resources;
using Windows.Networking.Proximity;

namespace NFCReceive
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            ProximityDevice device = ProximityDevice.GetDefault();

            // Make sure NFC is supported
            if (device!= null)
            {
                long Id = device.SubscribeForMessage ("Windows.SampleMessageType", messageReceived);
                //Debug.WriteLine("Published Message. ID is {0}", Id);

                 // Store the unique message Id so that it 
                // can be used to stop subscribing for this message type
            }
        }

        private void messageReceived(ProximityDevice sender, ProximityMessage message)
        {

             rcvBox.Text = message.DataAsString;
        }

            

        private void rcvButton_Click(object sender, RoutedEventArgs e)
        {               

            


        }
    }
        

        
        
    
}