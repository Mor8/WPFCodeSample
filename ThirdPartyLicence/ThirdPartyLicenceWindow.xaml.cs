using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Collections;

namespace ThirdPartyLicence
{
    /// <summary>
    /// ThirdPartyLicenceWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ThirdPartyLicenceWindow : Window
    {
        private List<Licence> licences = new List<Licence>();

        public ThirdPartyLicenceWindow()
        {
            InitializeComponent();
            Load();
            Display();
        }

        private void Load()
        {
            IEnumerable<string> pathes = Directory.EnumerateFiles("..\\..\\Licences", "*", SearchOption.AllDirectories);

            foreach(var path in pathes)
            {
                Licence licence = new Licence();
                using (StreamReader file = new StreamReader(path)  )
                {
                    licence.Name = System.IO.Path.GetFileName(path).Split('.')[0];
                    licence.URL = file.ReadLine();
                    licence.Terms = file.ReadToEnd();
                }
                licences.Add(licence);
            }
            
        }

        private void Display()
        {
            ThirdPartyLicencesTextBlock.Text = "";
            foreach (var licence in licences)
            {
                ThirdPartyLicencesTextBlock.Text += licence.Name +"\t";
                ThirdPartyLicencesTextBlock.Text += "( "+ licence.URL + " ) " + "\n";
                ThirdPartyLicencesTextBlock.Text += licence.Terms + "\n\n";
                ThirdPartyLicencesTextBlock.Text += "------------------------------------------------------------------\n";
            }
        }
    }
}
