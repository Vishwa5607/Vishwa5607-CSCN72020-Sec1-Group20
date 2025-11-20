using System; using System.Threading.Tasks; using System.Windows.Input;
namespace SmartClassroom.Environmental.ViewModels{
public class AVViewModel:BaseViewModel{
 private int st=0; private bool busy=false;
 public AVViewModel(){
  PowerOnCommand=new RelayCommand(async _=>await OnAsync(),_=>CanPowerOn);
  PowerOffCommand=new RelayCommand(async _=>await OffAsync(),_=>CanPowerOff);
 }
 public int ProjectorState{
  get=>st;
  set{ if(SetProperty(ref st,value)){OnPropertyChanged(nameof(ProjectorStateText));OnPropertyChanged(nameof(CanPowerOn));OnPropertyChanged(nameof(CanPowerOff));Raise();}}
 }
 public string ProjectorStateText=>st switch{0=>"OFF",1=>"WARMING UP",2=>"ON",3=>"COOLING DOWN",_=>"UNKNOWN"};
 public bool CanPowerOn=>!busy&&(st==0||st==3);
 public bool CanPowerOff=>!busy&&(st==2);
 public ICommand PowerOnCommand{get;}
 public ICommand PowerOffCommand{get;}
 private async Task OnAsync(){
  if(!CanPowerOn)return; busy=true;Raise();
  ProjectorState=1; await Task.Delay(2000);
  ProjectorState=2; busy=false;Raise();
 }
 private async Task OffAsync(){
  if(!CanPowerOff)return; busy=true;Raise();
  ProjectorState=3; await Task.Delay(2000);
  ProjectorState=0; busy=false;Raise();
 }
 private void Raise(){
  if(PowerOnCommand is RelayCommand a)a.RaiseCanExecuteChanged();
  if(PowerOffCommand is RelayCommand b)b.RaiseCanExecuteChanged();
 }
}}