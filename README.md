# frp-GUI
frp Windows GUI - 快速反向代理frp的Windows用户界面

# 简介
* v1.0版本已发布，可能存在一些bug，可在Release里下载。内含frpc v0.21.0。
* 本项目基于frp, https://github.com/fatedier/frp
* 放假无聊写出来的东西，这东西是我VB基本无基础自学四天写出来的，代码稍有不规范见谅，功能会慢慢添加的，部分功能还在开发中
* 以下是该模式下的服务器配置frps.ini的内容范例。
```
# frps.ini
[common]
bind_port = 7000
vhost_http_port = 8080
vhost_https_port = 4430
```
# 目的
为了方便frpc.ini的编辑和实现frpc的开机托盘启动，可以管理多个服务器和管理多个代理配置。