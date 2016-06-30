using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace OwinBlog
{
    partial class OwinService : ServiceBase
    {
        public OwinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string baseAddress = "http://localhost:9000/";
            //string baseAddress = "http://+:9000/"; //绑定所有地址，外网可以用ip访问 需管理员权限
            // 启动 OWIN host 
            WebApp.Start<Startup>(url: baseAddress);
        }

        protected override void OnStop()
        {
            // TODO:  在此处添加代码以执行停止服务所需的关闭操作。
        }
    }
}
