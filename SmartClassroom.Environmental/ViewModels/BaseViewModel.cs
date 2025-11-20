using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace SmartClassroom.Environmental.ViewModels {
public abstract class BaseViewModel : INotifyPropertyChanged {
 public event PropertyChangedEventHandler? PropertyChanged;
 protected void OnPropertyChanged([CallerMemberName] string? n=null)=> PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(n));
 protected bool SetProperty<T>(ref T b,T v,[CallerMemberName] string? n=null){
  if(Equals(b,v))return false; b=v; OnPropertyChanged(n); return true; }}}