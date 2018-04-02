using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_Manager_c
{
    public partial class errornet : Form
    {

        public String Errorcoderl;
        public String Whaterrorrl;
        public String WhatHappendrl;
        public String WhatIsNowPossiblerl;

        public errornet(String Errorcode, String Whaterror, String WhatHappend, String WhatIsNowPossible)
        {
            Errorcoderl = Errorcode;
            Whaterrorrl = Whaterror;
            WhatHappendrl = WhatHappend;
            WhatIsNowPossiblerl = WhatIsNowPossible;
            InitializeComponent();
        }

        private void errornet_Load(object sender, EventArgs e)
        {
            monoFlat_ThemeContainer1.Text = Errorcoderl + Whaterrorrl;
            monoFlat_Label1.Text = Errorcoderl;
            monoFlat_Label3.Text = WhatHappendrl;
            monoFlat_Label4.Text = WhatIsNowPossiblerl;
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
