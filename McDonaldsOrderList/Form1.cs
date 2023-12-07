using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonaldsOrderList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(960, 800);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Responsive();
        }


        public void Responsive()
        {
            // Form genişliğinin %2'si kadar boşluk bırak
            float spacePercentage = 2f;
            int spacing = (int)(this.Width * (spacePercentage / 100));

            // Her iki panelin toplam alabileceği genişliği hesapla
            int totalAvailableWidth = this.Width - spacing;

            // Her panel için genişlik
            int panelWidth = totalAvailableWidth / 2;

            // readyPanel ve preparingPanel'in genişliklerini ve konumlarını ayarla
            readyPanel.Width = panelWidth;
            preparingPanel.Width = panelWidth;

            // preparingPanel sol tarafta olacak, dolayısıyla konumu (0,0) olarak başlar
            preparingPanel.Location = new Point(0, preparingPanel.Location.Y);

            // readyPanel sağ tarafta olacak, dolayısıyla konumu preparingPanel'in genişliği + boşluk kadar olacak
            readyPanel.Location = new Point(preparingPanel.Width + spacing, readyPanel.Location.Y);

            // preparingOrdersPanel ve orderReadyPanel'in genişliklerini ve konumlarını ayarla
            preparingOrdersPanel.Width = panelWidth;
            orderReadyPanel.Width = panelWidth;

            // preparingOrdersPanel sol tarafta olacak, dolayısıyla konumu (0,0) olarak başlar
            preparingOrdersPanel.Location = new Point(0, preparingOrdersPanel.Location.Y);

            // orderReadyPanel sağ tarafta olacak, dolayısıyla konumu preparingOrdersPanel'in genişliği + boşluk kadar olacak
            orderReadyPanel.Location = new Point(preparingOrdersPanel.Width + spacing, orderReadyPanel.Location.Y);

            // readyLabel konumlarını ayarla
            readyLabel.Location = new Point(
           (orderReadyPanel.Width - readyLabel.Width) / 2,
               readyLabel.Location.Y
                     );
            // preparingLabel'in konumlarını ayarla
            preparingLabel.Location = new Point(
                (preparingOrdersPanel.Width - preparingLabel.Width) / 2,
                preparingLabel.Location.Y
            );
        }

    }
}
