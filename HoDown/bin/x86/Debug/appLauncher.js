
shell = new ActiveXObject("WScript.Shell");

!function() {
  /* 结束已经运行的aria2c.exe进程 */
  shell.Run("taskkill.exe /f /im aria2c.exe", 0, true);
  /* 以隐藏窗口的方式运行aria2 */
  shell.Run("aria2c.exe --conf-path=baidu.ini", 0);
}();
