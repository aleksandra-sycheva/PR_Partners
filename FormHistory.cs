using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4_Patners
{
    public partial class FormHistory : Form
    {
        private int id_Partner;
        public FormHistory(int id)
        {
            InitializeComponent();
            id_Partner = id;
        } 
    protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Models.AppContext db = new Models.AppContext())
            {
                dataGridViewHistory.DataSource = db.HistoryOfProducts
                    .Include(i => i.Product)
                    .Select(i => new { i.Product.Name, i.Count, i.DateOfSale, i.IdPartner })
                    .Where(x => x.IdPartner == id_Partner)
                    .ToList();
            }
        }
    }
}
