using ProvaTecnica.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnica.Business
{
    public class FileBll : IDisposable
    {
        public async Task<bool> Process(string pPath, string pType)
        {
            if (File.Exists(pPath))
            {
                try
                {
                    var content = File.ReadAllText(pPath);
                    var registers = ListRegisters(content);

                    foreach (var r in registers)
                    {
                        switch(pType)
                        {
                            case "C":
                                using (var bll = new CustomersBLL())
                                {
                                    await bll.PutCustomer(0, Customer.Convert(r));
                                }
                                break;
                            case "P":
                                using (var bll = new ProductsBLL())
                                {
                                    await bll.PutProduct(0, Product.Convert(r));
                                }
                                break;
                            default:
                                return false;
                        }
                    }

                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private IList<string> ListRegisters(string pData)
        {
            return pData.Split(';').ToList();
        }

        public void Dispose()
        {
            //
        }
    }
}