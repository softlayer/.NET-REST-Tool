' Copyright (c) 2010, SoftLayer Technologies, Inc. All rights reserved.
'
' Redistribution and use in source and binary forms, with or without 
' modification, are permitted provided that the following conditions are met:
'
' * Redistributions of source code must retain the above copyright notice, this 
'   list of conditions and the following disclaimer.
' * Redistributions in binary form must reproduce the above copyright notice, 
'   this list of conditions and the following disclaimer in the documentation 
'   and/or other materials provided with the distribution.
' * Neither SoftLayer Technologies, Inc. nor the names of its contributors may 
'   be used to endorse or promote products derived from this software without 
'   specific prior written permission.
'
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
' IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
' ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
' LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
' CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
' SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
' CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
' ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
' POSSIBILITY OF SUCH DAMAGE.

'+----------------------------------------------------------------------------------+
'|																				    |
'|	File: 				FrmMain.vb												    |
'|						=================================================		    |
'|	Dev Platform:		Win7 Professional							                |
'|	Dev Environment: 	Visual Studio.NET 2010 									    |
'|	Target:				Windows Desktop XP & >              					    |
'|	Purpose:			Demonstrate calling SoftLayer's RESTful API				    |
'|	Limitations:		Only rudimetary exception handling in place.    		    |
'|						=================================================		    |
'|	Dev Summary->																    |
'|   Revision:	Who:	When:   	What:										    |
'|   =========== ======= ===========	=========================================	|
'|   01.00.00	WJF		07/20/10	Original Creation (see restrictions)		    |
'+----------------------------------------------------------------------------------+

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Xml

Public Class frmMain

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	btnGet_Click     													    |
    '|	==================														|
    '|																			|
    '|	Inputs:		object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:		Default callback for button on click.                       | 
    '|               When someone clicks the GET button we will insantiate      |
    '|               an HTTPRequest, stuff the athorization into the header, &  |
    '|               send it off to the host as an HTTP get.  The response is   |
    '|               displayed in the response text box for the user to see.    |
    '+--------------------------------------------------------------------------+
    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click
        httpRequest("get")
    End Sub

    '+--------------------------------------------------------------------------+
    '|							            									|
    '|	btnPost_Click     						        					    |
    '|	==================					    								|
    '|																			|
    '|	Inputs:	    object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:	    Default callback for button on click.                       | 
    '|              When someone clicks the POST button we will insantiate      |
    '|              an HTTPRequest, stuff the athorization into the header,     |
    '|              write any parameters as body content, and send it off to    |
    '|              the host as an HTTP Post. The response is displayed in the  |
    '|              response text box for the user to see.                      |
    '+--------------------------------------------------------------------------+
    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        httpRequest("post")
    End Sub

    '+--------------------------------------------------------------------------+
    '|							            									|
    '|	btnPut_Click     						        					    |
    '|	==================					    								|
    '|																			|
    '|	Inputs:	    object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:	    Default callback for button on click.                       | 
    '|              When someone clicks the PUT button we will insantiate       |
    '|              an HTTPRequest, stuff the athorization into the header,     |
    '|              write any parameters as body content, and send it off to    |
    '|              the host as an HTTP PUT. The response is displayed in the   |
    '|              response text box for the user to see.                      |
    '+--------------------------------------------------------------------------+
    Private Sub btnPut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPut.Click
        httpRequest("put")
    End Sub

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	btnDelete_Click    													    |
    '|	==================														|
    '|																			|
    '|	Inputs:		object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:		 Default callback for button on click.                      | 
    '|               When someone clicks the DEL button we will insantiate      |
    '|               an HTTPRequest, stuff the athorization into the header, &  |
    '|               send it off to the host as an HTTP del.  The response is   |
    '|               displayed in the response text box for the user to see.    |
    '+--------------------------------------------------------------------------+
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        httpRequest("delete")
    End Sub

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	txtPostvars_TextChanged        										    |
    '|	=======================   	    										|
    '|																			|
    '|	Inputs:		Object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:		Default handler for text box changed event.                 | 
    '|              Any time we add something to the POST text box, only        |
    '|              HTTP post is valid.  If the contents of the text box        |
    '|              is null, only HTTP get is valid.  This method enables and   |
    '|              disables the appropriate buttons as per this logic.         |
    '+--------------------------------------------------------------------------+	
    Private Sub txtPostVars_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostVars.TextChanged
        If txtPostVars.TextLength > 0 Then
            btnGet.Enabled = False
            btnDelete.Enabled = False
            btnPost.Enabled = True
            btnPut.Enabled = True
        Else
            btnGet.Enabled = True
            btnDelete.Enabled = True
            btnPost.Enabled = False
            btnPut.Enabled = False
        End If
    End Sub

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	rdoGet_CheckedChanged        										    |
    '|	=======================   	    										|
    '|																			|
    '|	Inputs:		Object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:		Default handler for radio button changed event.             | 
    '|              Clear the response and post var text boxes.  Repopulate     |
    '|              with appropriate parameters to demontrate a get open        |
    '|              tickets call to the SLAP RESTful service.                   |
    '+--------------------------------------------------------------------------+
    Private Sub rdoGet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGet.CheckedChanged
        If rdoGet.Checked Then
            If getMode().Equals("XML") Then
                txtEndPoint.Text = "SoftLayer_Account/OpenTickets.xml"
            Else
                txtEndPoint.Text = "SoftLayer_Account/OpenTickets.json"
            End If
            txtResponse.Clear()
            txtPostVars.Clear()
        End If
    End Sub

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	rdoServers_ObjectMaskChanged   										    |
    '|	============================    										|
    '|																			|
    '|	Inputs:		Object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:		Default handler for radio button changed event.             | 
    '|              Clear the response and post var text boxes.  Repopulate     |
    '|              with appropriate parameters to demonstrate a get servers    |
    '|              call to the SLAP RESTful service by means of an object mask.|
    '+--------------------------------------------------------------------------+
    Private Sub rdoObjectMask_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoObjectMask.CheckedChanged
        If getMode().Equals("XML") Then
            txtEndPoint.Text = "SoftLayer_Account.xml?objectMask=hardware;virtualGuests"
        Else
            txtEndPoint.Text = "SoftLayer_Account.json?objectMask=hardware;virtualGuests"
        End If
        txtResponse.Clear()
        txtPostVars.Clear()
    End Sub

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	rdoPost_CheckedChanged      										    |
    '|	=========================  	    										|
    '|																			|
    '|	Inputs:		Object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID														|
    '|																			|
    '|	Notes:		Default handler for radio button changed event.             | 
    '|              Clear the response and post var text boxes.  Repopulate     |
    '|              with appropriate parameters to demonstrate a new            |
    '|              ticket request.  Note the user will have to replace both    |
    '|              the server id and user id with valid account data.          |
    '+--------------------------------------------------------------------------+
    Private Sub rdoPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPost.CheckedChanged
        Dim txt As [String] = ""
        If getMode().Equals("XML") Then
            txtEndPoint.Text = "SoftLayer_Ticket/createStandardTicket.xml"
            txt = "<?xml version=""1.0"" encoding=""utf-8""?><root><parameters><item>" & "<assignedUserId>INSERT YOUR USER ID HERE</assignedUserId><subjectId>1022</subjectId><notifyUserOnUpdateFlag>" & "true</notifyUserOnUpdateFlag></item><item>This is a test ticket. Please ignore.</item>" & "<item>INSERT VALID SERVER ID HERE</item><item>server password</item><item /><item /><item /><item>HARDWARE</item>" & "</parameters></root>"
        Else
            txt = "{""parameters"":[{""assignedUserId"":INSERT YOUR USER ID HERE,""subjectId"":1022,""notifyUserOnUpdateFlag"":true}," & """This is a test ticket.  Please ignore."",INSERT VALID SERVER ID HERE,""server password"",null,null,null,""HARDWARE""]}"
            txtEndPoint.Text = "SoftLayer_Ticket/createStandardTicket.json"
        End If
        txtResponse.Clear()
        txtPostVars.Clear()
        If getMode().Equals("XML") Then
            txtPostVars.Text = FormatXml(txt)
        Else
            txtPostVars.Text = FormatJSON(txt)
        End If
    End Sub

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	FormatXml      			                							    |
    '|	=========                 	    										|
    '|																			|
    '|	Inputs:		string unformattedXml										|
    '|																			|
    '|	Returns:	string formattedXml											|
    '|																			|
    '|	Notes:		Use this method to perform some basic housekeeping on       |
    '|              XML string before plunking them into a text box.  It will   |
    '|              make the output easier on the eyes.                         |
    '+--------------------------------------------------------------------------+
    Private Function FormatXml(ByVal unformattedXml As String) As String
        Dim xd As New XmlDocument()
        Try
            xd.LoadXml(unformattedXml)
        Catch [error] As Exception
            System.Windows.Forms.MessageBox.Show([error].Message.ToString())
            Return unformattedXml
        End Try
        Dim sb As New StringBuilder()
        Dim sw As New StringWriter(sb)
        Dim xtw As XmlTextWriter = Nothing
        Try
            xtw = New XmlTextWriter(sw)
            xtw.Formatting = Formatting.Indented
            xd.WriteTo(xtw)
        Finally
            If xtw IsNot Nothing Then
                xtw.Close()
            End If
        End Try
        Return sb.ToString()
    End Function

    '       +---------------------------------------------------------------------------+
    '       |																     	    |
    '       |	FormatJson      			                							|
    '       |	=========                 	    										|
    '       |																			|
    '       |	Inputs:		string unformattedJson										|
    '       |																			|
    '       |	Returns:	string formattedJson										|
    '       |																			|
    '       |	Notes:	   Use this method to perform some basic housekeeping on        |
    '       |              JSON string before plunking them into a text box.  It will   |
    '       |              make the output easier on the eyes.                          |
    '       +---------------------------------------------------------------------------+															
    Private Function FormatJSON(ByVal unformattedJSON As String) As String
        Dim sb As New StringBuilder()
        Dim chars As Char() = unformattedJSON.ToCharArray()
        Dim len As Integer = chars.Length
        Dim indent As Integer = 0
        Dim last_char As Char = " "c
        Dim new_line As Boolean = True
        For i As Integer = 0 To len - 1
            If chars(i) = "}"c Then
                new_line = True
                sb.AppendLine()
            ElseIf chars(i) = "{"c Then
                If i > 0 Then
                    sb.AppendLine()
                    For j As Integer = 0 To indent - 1
                        sb.Append(" "c)
                    Next
                End If
            End If
            If last_char = "}"c Then
                indent -= 3
            End If
            If last_char = "{"c Then
                new_line = True
                sb.AppendLine()
                indent += 3
            End If
            If last_char = ","c Then
                sb.AppendLine()
                new_line = True
            End If
            If new_line Then
                For j As Integer = 0 To indent - 1
                    sb.Append(" "c)
                Next
            End If
            sb.Append(chars(i))
            new_line = False
            last_char = chars(i)
        Next
        Return sb.ToString()
    End Function

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	ValidateServerCertificate   										    |
    '|	=========================   											|
    '|																			|
    '|	Inputs:		Object sender  												|
    '|              X509Certificate certificate                                 |
    '|              X509Chain chain                                             |
    '|              SslPolicyErrors sslPolicyErrors                             |
    '|																			|
    '|	Returns:	bool														|
    '|																			|
    '|	Notes:		Override to allow any host certificate.                     | 
    '+--------------------------------------------------------------------------+	
    Public Shared Function ValidateServerCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function

    '+--------------------------------------------------------------------------+
    '|																			|
    '|	txtPostvars_Leave		                							    |
    '|	=================          	    										|
    '|																			|
    '|	Inputs:		object sender (ignored)										|
    '|              EventArgs e   (ignored)                                     |
    '|																			|
    '|	Returns:	VOID            											|
    '|																			|
    '|	Notes:		Default event called when text box looses focus.            |
    '|              Whenever the user modifies the XML post vars we will see    |
    '|              if we can't pretty it up.                                   |
    '+--------------------------------------------------------------------------+	
    Private Sub txtPostVars_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostVars.Leave
        If txtPostVars.TextLength > 0 Then
            Dim txt As [String] = ""
            If getMode().Equals("XML") Then
                txt = FormatXml(txtPostVars.Text)
            Else
                txt = FormatJSON(txtPostVars.Text)
            End If
            txtPostVars.Text = txt
        End If
    End Sub

    '   +---------------------------------------------------------------------------+
    '   |																			|
    '   |	cmbDropDown_SelectedIndexChanged           							    |
    '   |	================================  										|
    '   |																			|
    '   |	Inputs:		object sender (ignored)										|
    '   |               EventArgs e   (ignored)                                     |
    '   |																			|
    '   |	Returns:	VOID            											|
    '   |																			|
    '   |	Notes:		Anytime the mode changes from JSON to XML or vice-versa     |
    '   |               we should clear our text boxes.                             |
    '   +---------------------------------------------------------------------------+															

    Private Sub cmbDropDown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDropDown.SelectedIndexChanged
        txtEndPoint.Text = ""
        txtPostVars.Text = ""
        txtResponse.Text = ""
    End Sub

    '       +----------------------------------------------------------------------------+
    '       |																			|
    '       |	getMode                                    							    |
    '       |	=======  			                        							|
    '       |																			|
    '       |	Inputs:	    VOID							            				|
    '       |																			|
    '       |	Returns:	VOID            											|
    '       |																			|
    '       |	Notes:	    Determine if user is expecting XML or JSON                  |
    '       +----------------------------------------------------------------------------+			
    Private Function getMode() As String
        If cmbDropDown.SelectedItem.ToString().Equals("XML Mode") Then
            Return "XML"
        Else
            Return "JSON"
        End If
    End Function
    '
    '       +----------------------------------------------------------------------------+
    '       |																			|
    '       |	httpRequest                                							    |
    '       |	===========			                        							|
    '       |																			|
    '       |	Inputs:	    string verb 					            				|
    '       |																			|
    '       |	Returns:	VOID            											|
    '       |																			|
    '       |	Notes:	   Accept 'put', 'post', 'get', or delete from the caller and   |
    '       |               perform the appropriate HTTP communications with the SLAPI   |
    '       |               server.                                                      |
    '       +----------------------------------------------------------------------------+															
    '       
    Private Sub httpRequest(ByVal verb As String)
        Try
            Dim url As String = txtApiUrl.Text + "/" + txtEndPoint.Text
            Dim req As HttpWebRequest = TryCast(WebRequest.Create(New Uri(url)), HttpWebRequest)
            Dim authPair As [String] = txtUserName.Text + ":" + txtApiKey.Text
            authPair = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authPair))
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf ValidateServerCertificate)
            req.Headers.Add("Authorization", "Basic " & authPair)
            req.Method = verb
            If getMode().Equals("XML") Then
                req.ContentType = "text/json"
            Else
                req.ContentType = "text/xml"
            End If
            If (verb.Equals("post")) OrElse (verb.Equals("put")) Then
                Dim content As Byte() = UTF8Encoding.UTF8.GetBytes(txtPostVars.Text.Trim())
                req.ContentLength = content.Length
                Using post As Stream = req.GetRequestStream()
                    post.Write(content, 0, content.Length)
                End Using
            End If
            Dim result As String = Nothing
            Using resp As HttpWebResponse = TryCast(req.GetResponse(), HttpWebResponse)
                Dim reader As New StreamReader(resp.GetResponseStream())
                result = reader.ReadToEnd()
            End Using
            If getMode().Equals("XML") Then
                txtResponse.Text = FormatXml(result)
            Else
                txtResponse.Text = FormatJSON(result)
            End If
        Catch [error] As Exception
            System.Windows.Forms.MessageBox.Show([error].Message.ToString())
        End Try
    End Sub

End Class

