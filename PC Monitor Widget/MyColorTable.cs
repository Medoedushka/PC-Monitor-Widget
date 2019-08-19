using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Monitor_Widget
{
    public class MyColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground // Рамка выпадающего списка.
        {
            get
            {
                return Color.FromArgb(255, 89, 0);
            }
        }

        public override Color ImageMarginGradientBegin // Рамка выпадающего списка.
        {
            get
            {
                return Color.FromArgb(255, 89, 0);
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(192, 255, 192);
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(192, 255, 192);
            }
        }

        public override Color MenuBorder // Граница выпадающего списка.
        {
            get
            {
                return Color.FromArgb(255, 89, 0);
            }
        }

        public override Color MenuItemBorder // Рамка выделяемого элемента.
        {
            get
            {
                return Color.FromArgb(255, 89, 0);
            }
        }

        public override Color MenuItemSelected // Цвет выделеного элемента.
        {
            get
            {
                return Color.FromArgb(58, 58, 59);
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 89, 0);
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 255, 255);
            }
        }

        public override Color MenuItemSelectedGradientBegin // Начало градиента выбраного элемента.
        {
            get
            {
                return Color.FromArgb(185, 118, 0);
            }
        }

        public override Color MenuItemSelectedGradientEnd // Концен градиента выбраного элемента.
        {
            get
            {
                return Color.FromArgb(58, 58, 59);
            }
        }

        public override Color MenuItemPressedGradientBegin // Начало градиента нажатого элемента.
        {
            get
            {
                return Color.FromArgb(38, 38, 38);
            }
        }

        public override Color MenuItemPressedGradientEnd // Конец градиента нажатого элемента.
        {
            get
            {
                return Color.FromArgb(38, 38, 38);
            }
        }

    }
}
