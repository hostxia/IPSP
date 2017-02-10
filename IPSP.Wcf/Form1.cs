using Abp;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSP.Wcf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var abpBootstrapper = new AbpBootstrapper())
            {
                Assembly.GetAssembly(typeof(IPSPApplicationModule)).GetTypes().Where(t => t.IsInterface && typeof(IApplicationService).IsAssignableFrom(t)).ToList().ForEach(t =>
                {
                    abpBootstrapper.Initialize();
                    var serviceHost = new ServiceHost(abpBootstrapper.IocManager.IocContainer.Resolve(t));
                    serviceHost.Open();
                });
            }
        }
    }
}
