using System; using System.Windows.Input;
namespace SmartClassroom.Environmental.ViewModels {
public class RelayCommand : ICommand{
 private readonly Action<object?> ex; private readonly Func<object?,bool>? can;
 public RelayCommand(Action<object?> e,Func<object?,bool>? c=null){ex=e;can=c;}
 public bool CanExecute(object? p)=>can?.Invoke(p)??true;
 public void Execute(object? p)=>ex(p);
 public event EventHandler? CanExecuteChanged;
 public void RaiseCanExecuteChanged()=>CanExecuteChanged?.Invoke(this,EventArgs.Empty);
}}