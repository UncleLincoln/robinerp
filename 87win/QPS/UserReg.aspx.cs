﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QPS.Web
{
    public partial class UserReg : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btn_Reg_Click(object sender, EventArgs e)
        //{
        //    int result;
        //    try
        //    {
        //        string celpattern = @"(^189\d{8}$)|(^13\d{9}$)|(^15\d{9}$)";
        //        if (txtPwd.Value != txtRePwd.Value)
        //        {
        //            Response.Write("<script>alert('确认密码与原密码不一致 ，请重新输入！ ')</script>");
        //            return;
        //        }
        //        if (txtShouj.Value != "")
        //        {
        //            if (!validate(txtShouj.Value, celpattern))
        //            {
        //                Response.Write("<script>alert('输入的手机号有错误,请重新输入！ ')</script>");
        //                return;
        //            }
        //        }
        //        string mailpattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        //        if (txtEm.Value != "")
        //        {
        //            if (!validate(this.txtEm.Value, mailpattern))
        //            {

        //                Response.Write("<script>alert(' 输入的邮箱格式有错误，请重新输入！')</script>");
        //                return;
        //            }
        //        }
        //        string usernamepattern = "^[A-Za-z0-9]+$";
        //        if (!validate(this.txtUser.Value, usernamepattern))
        //        {

        //            Response.Write("<script>alert(' 用户名只能是数字和字母！')</script>");
        //            return;
        //        }
        //        if (txtUser.Value.Length > 12 || txtUser.Value.Length < 6)
        //        {

        //            Response.Write("<script>alert('用户名 的长度不对，请重新输入！ ')</script>");
        //            return;
        //        }
        //        if (this.txtPwd.Value.Length > 20 || txtPwd.Value.Length < 6)
        //        {

        //            Response.Write("<script>alert('密码 的长度不对，请重新输入！')</script>");
        //            return;
        //        }
        //        if (this.txtNickname.Value.Length > 6 || txtNickname.Value.Length < 2)
        //        {
        //            Response.Write("<script>alert('用户 昵称 的长度不对，请重新输入！ ')</script>");
        //            return;
        //        }
        //        string NickNamePattern = "[\u4e00-\u9fa5]{2,6}";
        //        if (!validate(this.txtNickname.Value, NickNamePattern))
        //        {
        //            Response.Write("<script>alert('用户 昵称的格式不对，请重新输入！ ')</script>");
        //            return;
        //        }
        //        if (!checkbox.Checked)
        //            return;
        //        if (rbtuser.Checked)
        //        {
        //            //if (pa.getStatus(pa.regist("http://59.175.238.107:8080", txtUser.Value, txtPwd.Value, txtNickname.Value, "48c93e18ffbe4878b344cc1749ff6dc8")) != "true")
        //            //{
        //            //    Response.Write("<script>alert('注册失败！')</script>");
        //            //    return;
        //            //}
        //            Uuser.Username = txtUser.Value.Trim();
        //            Uuser.Address = txtDz.Value.Trim();
        //            Uuser.Mail = txtEm.Value.Trim();
        //            Uuser.Password = txtPwd.Value.Trim();
        //            Uuser.Phone = txtShouj.Value.Trim();
        //            Uuser.Nickname = txtNickname.Value.Trim();
        //            Uuser.Action = "regist";
        //            Uuser.Sign = "48c93e18ffbe4878b344cc1749ff6dc8";
        //            Uuser.Usertype = 0;

        //            result = Buser.Add(Uuser);
        //            if (result == 1)
        //            {
        //                Response.Write("<script>alert('创建普通用户成功!');window.location.href = 'UserLogin.aspx';</script>");
        //            }
        //            else if (result == -1)
        //            {
        //                Response.Write("<script>alert('该用户名已经被注册！ ')</script>");
        //            }
        //            else
        //            {
        //                Response.Write("<script>alert('创建用户失败！ ')</script>");
        //            }
        //        }
        //        if (rbtBusiuser.Checked)
        //        {
        //            this.Muser.Username = txtUser.Value.Trim();
        //            Muser.Address = txtDz.Value.Trim();
        //            Muser.Mail = txtEm.Value.Trim();
        //            Muser.Password = txtPwd.Value.Trim();
        //            Muser.Phone = txtShouj.Value.Trim();
        //            Muser.Nickname = txtNickname.Value.Trim();
        //            // === jeffery add
        //            Muser.IfChecked = 0;
        //            // ===
        //            result = Euser.Add(Muser);
        //            if (result == 1)
        //            {
        //                Response.Write("<script>alert('创建企业用户成功，等待审核！ ')</script>");
        //                Response.Redirect("UserLogin.aspx");
        //            }
        //            else if (result == -1)
        //            {
        //                Response.Write("<script>alert('该用户名已经被注册！ ')</script>");
        //            }
        //            else
        //            {
        //                Response.Write("<script>alert('创建用户失败！ ')</script>");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script>alert('创建用户失败！ ')</script>");
        //    }
        //}
    }
}

