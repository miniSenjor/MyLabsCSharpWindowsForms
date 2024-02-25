using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        List<int> setA = new List<int>();
        List<int> setB = new List<int>();
        List<int> setC = new List<int>();
        int operation = 0;

        private void chk1G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 1);
        }

        private void chk2G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 2);
        }

        private void chk3G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 3);
        }

        private void chk4G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 4);
        }

        private void chk5G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 5);
        }

        private void chk6G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 6);
        }

        private void chk7G1_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setA, setB, 7);
        }

        private void chk1G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 1);
        }

        private void chk2G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 2);
        }

        private void chk3G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 3);
        }

        private void chk4G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 4);
        }

        private void chk5G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 5);
        }

        private void chk6G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 6);
        }

        private void chk7G2_CheckedChanged(object sender, EventArgs e)
        {
            changeSet(setB, setA, 7);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setC.Clear();
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                {
                    operation = 0;
                    foreach (int i in setA)
                        if (setB.Contains(i))
                            setC.Add(i);
                }
                    break;
                case 1:
                {
                    operation = 1;
                    foreach (int i in setA)
                        if (!setC.Contains(i))
                            setC.Add(i);
                    foreach (int i in setB)
                        if (!setC.Contains(i))
                            setC.Add(i);
                }
                    break;
                case 2:
                {
                    operation = 2;
                    foreach (int i in setA)
                        if (!setB.Contains(i))
                            setC.Add(i);

                }
                    break;
            }
            writeInChkFromList(setC);
        }

        void changeSet(List<int> set1, List<int> set2, int day)
        {
            if (set1.Contains(day))
            {
                set1.Remove(day);
            }
            else set1.Add(day);

            switch (operation)
            {
                case 0:
                    if (set1.Contains(day) && set2.Contains(day) && !setC.Contains(day))
                        setC.Add(day);
                    else setC.Remove(day);
                    break;
                case 1:
                    if ((set1.Contains(day) || set2.Contains(day)) && !setC.Contains(day))
                        setC.Add(day);
                    else setC.Remove(day);
                    break;
                case 2:
                    if (setB.Contains(day) || !setA.Contains(day)) 
                        setC.Remove(day);
                    else if (setA.Contains(day) && !setC.Contains(day))
                        setC.Add(day);
                    break;
            }
            Control control = groupBox3.Controls[day - 1];
            if (control is CheckBox chk)
            {
                chk.Checked = setC.Contains(day);
            }
            else writeInChkFromList(setC);
            isSetContainSet();
        }

        void isSetContainSet()
        {
            bool AContainedInB = true;
            foreach (int i in setA)
            {
                if (!setB.Contains(i))
                {
                    AContainedInB = false;
                    break;
                }
            }
            chkSetAContainedInB.Checked = AContainedInB;

            bool BContainedInA = true;
            foreach (int i in setB)
            {
                if (!setA.Contains(i))
                {
                    BContainedInA = false;
                    break;
                }
            }
            chkSetBContainedInA.Checked = BContainedInA;

            if (AContainedInB && BContainedInA)
                chkAEqualToB.Checked = true;
            else chkAEqualToB.Checked = false;
        }

        void writeInChkFromList(List<int> set)
        {
            foreach (CheckBox chk in groupBox3.Controls.OfType<CheckBox>())
            {
                int index = groupBox3.Controls.IndexOf(chk)+1;
                if (set.Contains(index))
                    chk.Checked = true;
                else chk.Checked = false;
            }
        }

        private void z1_Load(object sender, EventArgs e)
        {
            isSetContainSet();
            comboBox1.SelectedIndex = 0;
        }
    }
}
