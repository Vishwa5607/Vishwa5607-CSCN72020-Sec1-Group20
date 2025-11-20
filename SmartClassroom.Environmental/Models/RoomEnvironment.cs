using System;
namespace SmartClassroom.Environmental.Models{
public class RoomEnvironment{
 public string RoomId {get;set;}="";
 public double TemperatureC{get;set;}
 public double HumidityPercent{get;set;}
 public double Co2Ppm{get;set;}
 public StatusSeverity Status{get;set;}
 public DateTime LastUpdated{get;set;}
 public double SetpointC{get;set;}=22;
 public HvacMode Mode{get;set;}=HvacMode.Auto;
}}