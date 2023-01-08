using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Deployment.Application;
using System.IO;

namespace WindowsFormsApp1.Models
{
  internal class ApplicationDbContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      //optionsBuilder.UseSqlite("Data Source=D:\\McProtocol_EntityFrameworkCoreNet2_Database_Path\\DB\\Database.db");
      //optionsBuilder.UseSqlite($"Data Source = {Application.StartupPath}\\hhhh.db");
      //string cs = @"URI=file:" + Application.StartupPath + "\\datatable.db";
      var sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
       "\\todo.db");
      optionsBuilder.UseSqlite("Data Source ="+sqlitePath);

    }
    public DbSet<Student> Students { get; set; }
  }
}
