using DevExpress.DevAV;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
#if DXCORE3
using DevExpress.Mvvm.DataModel.EFCore;
#else
using DevExpress.Mvvm.DataModel.EF6;
#endif

namespace DevExpress.DevAV.DevAVDbDataModel {

    /// <summary>
    /// A DevAVDbUnitOfWork instance that represents the run-time implementation of the IDevAVDbUnitOfWork interface.
    /// </summary>
    public class DevAVDbUnitOfWork : DbUnitOfWork<DevAVDb>, IDevAVDbUnitOfWork {

        public DevAVDbUnitOfWork(Func<DevAVDb> contextFactory)
            : base(contextFactory) {
        }

        IRepository<TaskAttachedFile, long> IDevAVDbUnitOfWork.AttachedFiles {
            get { return GetRepository(x => x.Set<TaskAttachedFile>(), (TaskAttachedFile x) => x.Id); }
        }

        IRepository<EmployeeTask, long> IDevAVDbUnitOfWork.Tasks {
            get { return GetRepository(x => x.Set<EmployeeTask>(), (EmployeeTask x) => x.Id); }
        }

        IRepository<Employee, long> IDevAVDbUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.Id); }
        }

        IRepository<CustomerCommunication, long> IDevAVDbUnitOfWork.Communications {
            get { return GetRepository(x => x.Set<CustomerCommunication>(), (CustomerCommunication x) => x.Id); }
        }

        IRepository<CustomerEmployee, long> IDevAVDbUnitOfWork.CustomerEmployees {
            get { return GetRepository(x => x.Set<CustomerEmployee>(), (CustomerEmployee x) => x.Id); }
        }

        IRepository<Customer, long> IDevAVDbUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.Id); }
        }

        IRepository<CustomerStore, long> IDevAVDbUnitOfWork.CustomerStores {
            get { return GetRepository(x => x.Set<CustomerStore>(), (CustomerStore x) => x.Id); }
        }

        IRepository<Crest, long> IDevAVDbUnitOfWork.Crests {
            get { return GetRepository(x => x.Set<Crest>(), (Crest x) => x.Id); }
        }

        IRepository<Order, long> IDevAVDbUnitOfWork.Orders {
            get { return GetRepository(x => x.Set<Order>(), (Order x) => x.Id); }
        }

        IRepository<OrderItem, long> IDevAVDbUnitOfWork.OrderItems {
            get { return GetRepository(x => x.Set<OrderItem>(), (OrderItem x) => x.Id); }
        }

        IRepository<Product, long> IDevAVDbUnitOfWork.Products {
            get { return GetRepository(x => x.Set<Product>(), (Product x) => x.Id); }
        }

        IRepository<ProductCatalog, long> IDevAVDbUnitOfWork.ProductCatalogs {
            get { return GetRepository(x => x.Set<ProductCatalog>(), (ProductCatalog x) => x.Id); }
        }

        IRepository<ProductImage, long> IDevAVDbUnitOfWork.ProductImages {
            get { return GetRepository(x => x.Set<ProductImage>(), (ProductImage x) => x.Id); }
        }

        IRepository<Picture, long> IDevAVDbUnitOfWork.Pictures {
            get { return GetRepository(x => x.Set<Picture>(), (Picture x) => x.Id); }
        }

        IRepository<QuoteItem, long> IDevAVDbUnitOfWork.QuoteItems {
            get { return GetRepository(x => x.Set<QuoteItem>(), (QuoteItem x) => x.Id); }
        }

        IRepository<Quote, long> IDevAVDbUnitOfWork.Quotes {
            get { return GetRepository(x => x.Set<Quote>(), (Quote x) => x.Id); }
        }

        IRepository<Evaluation, long> IDevAVDbUnitOfWork.Evaluations {
            get { return GetRepository(x => x.Set<Evaluation>(), (Evaluation x) => x.Id); }
        }

        IRepository<Probation, long> IDevAVDbUnitOfWork.Probations {
            get { return GetRepository(x => x.Set<Probation>(), (Probation x) => x.Id); }
        }

        IRepository<State, StateEnum> IDevAVDbUnitOfWork.States {
            get { return GetRepository(x => x.Set<State>(), (State x) => x.ShortName); }
        }

        IRepository<DatabaseVersion, long> IDevAVDbUnitOfWork.Version {
            get { return GetRepository(x => x.Set<DatabaseVersion>(), (DatabaseVersion x) => x.Id); }
        }
    }
}
