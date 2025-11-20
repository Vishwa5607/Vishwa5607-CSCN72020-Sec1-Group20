using System;
using SmartClassroom.Environmental.Models;
namespace SmartClassroom.Environmental.Services{
public sealed class MessageBus{
 private static readonly Lazy<MessageBus> L=new(()=>new MessageBus());
 public static MessageBus Instance=>L.Value;
 private MessageBus(){}
 public event Action<RoomEnvironment>? EnvironmentUpdated;
 public event Action<ControlCommand>? ControlCommandIssued;
 public void PublishEnvironment(RoomEnvironment e)=>EnvironmentUpdated?.Invoke(e);
 public void PublishControlCommand(ControlCommand c)=>ControlCommandIssued?.Invoke(c);
}}