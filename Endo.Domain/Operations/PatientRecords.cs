using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.Domain.Operations
{
  public class PatientRecordOperation
  {
    public long Id { get; set; }
    public DateTime RecordDate { get; set; }
    public int MeasureOne { get; set; }
  }
}
