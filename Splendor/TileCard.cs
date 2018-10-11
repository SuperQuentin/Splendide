using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor
{
    public partial class TileCard : Control
    {
        public Ressources ress { get; protected set; }
        public int prestigePt { get; protected set; }
        public int level { get; protected set; }
        public int[] cout { get; protected set; } = new int[4];

        public TileCard()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
