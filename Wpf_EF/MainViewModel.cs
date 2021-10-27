using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_EF
{
    internal class MainViewModel
    {
        private readonly UserDbContext _context = new UserDbContext();
        private readonly UadDbContext _uadContext = new UadDbContext();

        public ObservableCollection<Customer> Customers { get; set; }
        public ObservableCollection<Fixture> Fixtures { get; set; }

        public MainViewModel()
        {
            // this is for demo purposes only, to make it easier
            // to get up and running
            //_context.Database.EnsureCreated();
            _uadContext.Database.EnsureCreated();

            // load the entities into EF Core
            //_context.Customers.Load();
            _uadContext.Fixtures.Load();

            // bind to the source
            //Customers = _context.Customers.Local.ToObservableCollection();
            Fixtures = _uadContext.Fixtures.Local.ToObservableCollection();
        }
    }
}
