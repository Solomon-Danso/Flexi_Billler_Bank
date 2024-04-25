using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Flexi_Biller_Back.Models;
using Microsoft.EntityFrameworkCore;




namespace Flexi_Biller_Back.Data
{
    public class DataContext:DbContext
    {
                //Empty constructor
public DataContext(): base(){
}

//Database Connection String
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
base.OnConfiguring(optionsBuilder); optionsBuilder.UseSqlServer("Server=localhost,1433;Database=FlexiBiller;User=sa;Password=HydotTech;TrustServerCertificate=true;");
}
//Data Set, where Project and User are models in the Model folder

public DbSet<InstituitionBillingTable> BillingTable => Set<InstituitionBillingTable>(); 
public DbSet<PaymentHistory> PaymentHis => Set<PaymentHistory>(); 
public DbSet<Authenticate> Auth => Set<Authenticate>(); 













    }
}