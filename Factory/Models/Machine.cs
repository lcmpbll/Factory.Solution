using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntites = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntites { get; set; }
  }
}