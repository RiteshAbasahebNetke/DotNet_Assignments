using Core;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IBookedAppointmentsRepo:IGenericRepo<BookedAppointments>
    {
        void Add(BookAppVM rec);
    }
}
