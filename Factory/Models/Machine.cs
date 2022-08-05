using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    private bool _broken = false;
    public bool Broken { get { return _broken; } set { _broken = value; } }
    private bool _underRepair = false; 
    public bool UnderRepair { get { return _underRepair; } set { _underRepair = value; } }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}