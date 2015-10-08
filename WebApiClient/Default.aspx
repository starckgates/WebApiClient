﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApiClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap/bootstrap-theme.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <div style="padding: 50px 50px 10px;">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">webapi客户端测试</h3>
                </div>
                <div class="panel-body">
                    <div class="container">
                        <div class="row">
                            <div class="span12">
                                <div class="row">
                                    <div class="span6">
                                        <div class="col-lg-2">
                                            <span class="label label-primary">主要参数</span>
                                            <div>
                                                <br />
                                            </div>
                                            <div class="input-group input-group-sm">
                                                <span class="input-group-addon">keyword</span>
                                                <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                            <br />
                                            <div class="input-group input-group-sm">
                                                <span class="input-group-addon">flag</span>
                                                <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                            <br />
                                            <div class="input-group input-group-sm">
                                                <span class="input-group-addon">field</span>
                                                <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="span6">
                                        <div class="col-lg-4">
                                            <span class="label label-danger">签名参数</span>
                                            <div>
                                                <br />
                                            </div>
                                            <div class="input-group input-group-sm">
                                                <span class="input-group-addon">Timestamp</span>
                                                <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Button1" runat="server" Text="Submit" class="btn " />
                                                </span>
                                            </div>
                                            <br />
                                            <div class="input-group input-group-sm">
                                                <span class="input-group-addon">MD5</span>
                                                <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Button2" runat="server" Text="Submit" class="btn " />
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="span12">
                                        <br />
                                        <div class="col-lg-6">
                                            <div class="input-group input-group-sm">
                                                <span class="input-group-addon">url</span>
                                                <asp:TextBox ID="TextBox6" runat="server" class="form-control"></asp:TextBox>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Button3" runat="server" Text="Submit" class="btn " />
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">返回结果</h3>
                </div>
                <div class="panel-body"></div>
            </div>
        </div>

    </form>
    <script src="js/jquery/jquery-1.11.3.min.js"></script>
    <script src="js/bootstrap/bootstrap.min.js"></script>
</body>
</html>