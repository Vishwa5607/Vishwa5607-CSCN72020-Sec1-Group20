using System; using System.Collections.Generic;
namespace SmartClassroom.Environmental.Models{
public class ControlCommand{
 public string DeviceId{get;set;}="";
 public string Action{get;set;}="";
 public Dictionary<string,object> Parameters{get;set;}=new();
 public string RequestId{get;}=Guid.NewGuid().ToString();
}}