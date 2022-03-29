using LN_40.ApplicationExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LN_40.Models
{
    internal class Pharmacy
    {
        public int MedicineLimit { get; set; }
        public List<Medicine> Medicines { get; set; }

        public Pharmacy(int limit)
        {
            MedicineLimit = limit;
            Medicines = new List<Medicine>();
        }
        public void AddMedicine(Medicine medicine)
        {
            var med = Medicines.FirstOrDefault(e => e.Name == medicine.Name);

            if (med != null)
            {
                throw new MedicineAlreadyExistsException();
            }
            else
            {
                if (Medicines.Count < MedicineLimit)
                {
                    Medicines.Add(med);
                }
                else
                {
                    throw new CapacityLimitException();
                }
            }

        }
        public List<Medicine> FilterMedicinesByPrice(int minPrice, int maxPrice)
        {
            List<Medicine> medicines  = Medicines.Where(m=> m.Price > minPrice && m.Price < maxPrice).ToList();
            return medicines;
        }
        public Medicine GetMedicineById(int? id)
        {
            if(id==null)
            {
                throw new NullReferenceException();
            }
            else
            {
                var med = Medicines.FirstOrDefault(e => e.Id == id);
                if(med==null)
                {
                    throw new NotFoundException();
                }
                return med;

            }

        }
        public void DeleteMedicineById(int? id)
        {
            
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                var med = Medicines.FirstOrDefault(e => e.Id == id);
                if (med == null)
                {
                    throw new NotFoundException();
                }
                med.IsDeleted = true;

            }
        }
        public void EditMedicineName(int?id,string name)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                var med = Medicines.FirstOrDefault(e => e.Id == id);
                if (med == null)
                {
                    throw new NotFoundException();
                }
                med.Name = name;

            }

        }

        public List<Medicine> GetAllMedicines()
        {
            return Medicines;
        }

    }
}
