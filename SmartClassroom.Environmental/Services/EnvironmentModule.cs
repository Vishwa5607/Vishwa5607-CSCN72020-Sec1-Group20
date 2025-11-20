using System; using System.Collections.Generic; using System.IO; using System.Linq; using System.Timers;
using SmartClassroom.Environmental.Models;
namespace SmartClassroom.Environmental.Services{
public class EnvironmentModule:IDisposable{
 private readonly MessageBus bus=MessageBus.Instance;
 private Timer t;
 public EnvironmentModule(string d){
  t=new Timer(2000); t.Elapsed+=(s,e)=>{}; t.Start();
 }
 public void Dispose(){t.Stop();t.Dispose();}
}}