﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class ReconocimientoFacial : Form
    {
        public ReconocimientoFacial()
        {
            InitializeComponent();
        }

        private void ReconocimientoFacial_Click(object sender, EventArgs e)
        {
            _Global.Cerrar(this);
        }
    }
}
