using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsAE
{
    class MapOpenOperation
    {
        public void OpenMxd(ESRI.ArcGIS.Controls.AxMapControl axMapControl)
        {
            OpenFileDialog dg = new OpenFileDialog();
            dg.Title = "打开地图";
            dg.Filter = "Map Document (*.mxd)|*.mxd";
            if (dg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dg.FileName;
                if (string.IsNullOrEmpty(fileName))
                    return;
                axMapControl.LoadMxFile(fileName);
            }
        }

        public void OpenShapefile()
        {
            int i = 1;
        }
    }
}
