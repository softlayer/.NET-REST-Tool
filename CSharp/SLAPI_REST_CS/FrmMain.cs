// Copyright (c) 2010, SoftLayer Technologies, Inc. All rights reserved.
//
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met:
//
// * Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer.
// * Redistributions in binary form must reproduce the above copyright notice, 
//   this list of conditions and the following disclaimer in the documentation 
//   and/or other materials provided with the distribution.
// * Neither SoftLayer Technologies, Inc. nor the names of its contributors may 
//   be used to endorse or promote products derived from this software without 
//   specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF 
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.

/*
	+-------------------------------------------------------------------------------+
    |																				|
	|	File: 				FrmMain.cs												|
	|						=================================================		|
	|	Dev Platform:		Win7 Professional							            |
	|	Dev Environment: 	Visual Studio.NET 2010 									|
	|	Target:				Windows Desktop XP & >              					|
	|	Purpose:			Demonstrate calling SoftLayer's RESTful API				|
	|	Limitations:		Only rudimetary exception handling in place.    		|
	|						=================================================		|
	|	Dev Summary->																|
	|   Revision:	Who:	When:   	What:										|
    |   =========== ======= ===========	=========================================	|
    |   01.00.00	WJF		07/20/10	Original Creation (see restrictions)		|
	+-------------------------------------------------------------------------------+
         
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Xml;

namespace SLAPI_REST_CS
{
    public partial class frmMain : Form
    {
        /*
	    +---------------------------------------------------------------------------+
	    |																			|
	    |	frmMain     														    |
	    |	==================														|
	    |																			|
	    |	Inputs:		VOID        												|
	    |																			|
	    |	Returns:	VOID														|
	    |																			|
	    |	Notes:		Default constructor.                                        | 
	    +---------------------------------------------------------------------------+															
        */
        public frmMain()
        {
            InitializeComponent();
        }

       /*
       +---------------------------------------------------------------------------+
       |																			|
       |	btnDelete_Click    													    |
       |	==================														|
       |																			|
       |	Inputs:	   object sender (ignored)										|
       |               EventArgs e   (ignored)                                      |
       |																			|
       |	Returns:	VOID														|
       |																			|
       |	Notes:	   Default callback for button on click.                        | 
       |               When someone clicks the DEL button we will insantiate        |
       |               an HTTPRequest, stuff the athorization into the header, and  |
       |               send it off to the host as an HTTP DEL.  The response is     |
       |               displayed in the response text box for the user to see.      |
       +----------------------------------------------------------------------------+															
       */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            httpRequest("delete");
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	btnGet_Click     													    |
        |	==================														|
        |																			|
        |	Inputs:		object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID														|
        |																			|
        |	Notes:		Default callback for button on click.                       | 
        |               When someone clicks the GET button we will insantiate       |
        |               an HTTPRequest, stuff the athorization into the header, and |
        |               send it off to the host as an HTTP get.  The response is    |
        |               displayed in the response text box for the user to see.     |
        +---------------------------------------------------------------------------+															
        */
        private void btnGet_Click(object sender, EventArgs e)
        {
            httpRequest("get");
        }

       /*
       +----------------------------------------------------------------------------+
       |							            									|
       |	btnPost_Click     						        					    |
       |	==================					    								|
       |																			|
       |	Inputs:	    object sender (ignored)										|
       |                EventArgs e   (ignored)                                     |
       |																			|
       |	Returns:	VOID														|
       |																			|
       |	Notes:	   Default callback for button on click.                        | 
       |               When someone clicks the POST button we will insantiate       |
       |               an HTTPRequest, stuff the athorization into the header,      |
       |               write any parameters as body content, and send it off to     |
       |               the host as an HTTP Post. The response is displayed in the   |
       |               response text box for the user to see.                       |
       +----------------------------------------------------------------------------+															
       */
        private void btnPost_Click(object sender, EventArgs e)
        {
            httpRequest("post");
        }
       
       /*
       +----------------------------------------------------------------------------+
       |							            									|
       |	btnPut_Click     						        					    |
       |	==================					    								|
       |																			|
       |	Inputs:	    object sender (ignored)										|
       |                EventArgs e   (ignored)                                     |
       |																			|
       |	Returns:	VOID														|
       |																			|
       |	Notes:	   Default callback for button on click.                        | 
       |               When someone clicks the PUT button we will insantiate        |
       |               an HTTPRequest, stuff the athorization into the header,      |
       |               write any parameters as body content, and send it off to     |
       |               the host as an HTTP Put. The response is displayed in the    |
       |               response text box for the user to see.                       |
       +----------------------------------------------------------------------------+															
       */

        private void btnPut_Click(object sender, EventArgs e)
        {
            httpRequest("put");
        }

        /*
	    +---------------------------------------------------------------------------+
	    |																			|
	    |	ValidateServerCertificate   										    |
	    |	=========================   											|
	    |																			|
	    |	Inputs:		Object sender  												|
        |               X509Certificate certificate                                 |
        |               X509Chain chain                                             |
        |               SslPolicyErrors sslPolicyErrors                             |
	    |																			|
	    |	Returns:	bool														|
	    |																			|
	    |	Notes:		Override to allow any host certificate.                     | 
	    +---------------------------------------------------------------------------+															
        */
        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	txtPostvars_TextChanged        										    |
        |	=======================   	    										|
        |																			|
        |	Inputs:		Object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID														|
        |																			|
        |	Notes:		Default handler for text box changed event.                 | 
        |               Any time we add something to the POST text box, only        |
        |               HTTP post is valid.  If the contents of the text box        |
        |               is null, only HTTP get is valid.  This method enables and   |
        |               disables the appropriate buttons as per this logic.         |
        +---------------------------------------------------------------------------+															
        */
        private void txtPostvars_TextChanged(object sender, EventArgs e)
        {
            if (txtPostvars.TextLength > 0)
            {
                btnGet.Enabled = false;
                btnDelete.Enabled = false;
                btnPost.Enabled = true;
                btnPut.Enabled = true;
            }
            else
            {
                btnGet.Enabled = true;
                btnDelete.Enabled = true;
                btnPost.Enabled = false;
                btnPut.Enabled = false;
            }
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	rdoGet_CheckedChanged        										    |
        |	=======================   	    										|
        |																			|
        |	Inputs:		Object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID														|
        |																			|
        |	Notes:		Default handler for radio button changed event.             | 
        |               Clear the response and post var text boxes.  Repopulate     |
        |               with appropriate parameters to demontrate a get open        |
        |               tickets call to the SLAP RESTful service.                   |
        +---------------------------------------------------------------------------+															
        */
        private void rdoGet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGet.Checked)
            {
                if (getMode().Equals("XML"))
                {
                    txtEndPoint.Text = "SoftLayer_Account/OpenTickets.xml";
                }
                else
                {
                    txtEndPoint.Text = "SoftLayer_Account/OpenTickets.json";
                }
                txtResponse.Clear();
                txtPostvars.Clear();
            }
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	rdoServers_ObjectMaskChanged   										    |
        |	============================    										|
        |																			|
        |	Inputs:		Object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID														|
        |																			|
        |	Notes:		Default handler for radio button changed event.             | 
        |               Clear the response and post var text boxes.  Repopulate     |
        |               with appropriate parameters to demonstrate a get servers    |
        |               call to the SLAP RESTful service by means of an object mask.|
        +---------------------------------------------------------------------------+															
        */
        private void rdoObjectMask_CheckedChanged(object sender, EventArgs e)
        {
            if (getMode().Equals("XML"))
            {
                txtEndPoint.Text = "SoftLayer_Account.xml?objectMask=hardware;virtualGuests";
            }
            else
            {
                txtEndPoint.Text = "SoftLayer_Account.json?objectMask=hardware;virtualGuests";
            }
            txtResponse.Clear();
            txtPostvars.Clear();
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	rdoPost_CheckedChanged      										    |
        |	=========================  	    										|
        |																			|
        |	Inputs:		Object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID														|
        |																			|
        |	Notes:		Default handler for radio button changed event.             | 
        |               Clear the response and post var text boxes.  Repopulate     |
        |               with appropriate parameters to demonstrate a new            |
        |               ticket request.  Note the user will have to replace both    |
        |               the server id and user id with valid account data.          |
        +---------------------------------------------------------------------------+															
        */
        private void rdoPost_CheckedChanged(object sender, EventArgs e)
        {
            String txt = "";
            if (getMode().Equals("XML"))
            {
                txtEndPoint.Text = "SoftLayer_Ticket/createStandardTicket.xml";
                txt = "<?xml version=\"1.0\" encoding=\"utf-8\"?><root><parameters><item>" +
                "<assignedUserId>INSERT YOUR USER ID HERE</assignedUserId><subjectId>1022</subjectId><notifyUserOnUpdateFlag>" +
                "true</notifyUserOnUpdateFlag></item><item>This is a test ticket. Please ignore.</item>" +
                "<item>INSERT VALID SERVER ID HERE</item><item>server password</item><item /><item /><item /><item>HARDWARE</item>" +
                "</parameters></root>";
            }
            else
            {
                txt = "{\"parameters\":[{\"assignedUserId\":INSERT YOUR USER ID HERE,\"subjectId\":1022,\"notifyUserOnUpdateFlag\":true}," +
                       "\"This is a test ticket.  Please ignore.\",INSERT VALID SERVER ID HERE,\"server password\",null,null,null,\"HARDWARE\"]}";
                txtEndPoint.Text = "SoftLayer_Ticket/createStandardTicket.json";
            }
            txtResponse.Clear();
            txtPostvars.Clear();
            if (getMode().Equals("XML"))
            {
                txtPostvars.Text = FormatXml(txt);
            }
            else
            {
                txtPostvars.Text = FormatJSON(txt);
            }
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	FormatXml      			                							    |
        |	=========                 	    										|
        |																			|
        |	Inputs:		string unformattedXml										|
        |																			|
        |	Returns:	string formattedXml											|
        |																			|
        |	Notes:		Use this method to perform some basic housekeeping on       |
        |               XML string before plunking them into a text box.  It will   |
        |               make the output easier on the eyes.                         |
        +---------------------------------------------------------------------------+															
        */
        private string FormatXml(string unformattedXml)
        {
            XmlDocument xd = new XmlDocument();
            try
            {
                xd.LoadXml(unformattedXml);
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message.ToString());
                return unformattedXml;
            }
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            XmlTextWriter xtw = null;
            try
            {
                xtw = new XmlTextWriter(sw);
                xtw.Formatting = Formatting.Indented;
                xd.WriteTo(xtw);
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
            }
            return sb.ToString();
        }

        /*
       +----------------------------------------------------------------------------+
       |																     	    |
       |	FormatJson      			                							|
       |	=========                 	    										|
       |																			|
       |	Inputs:		string unformattedJson										|
       |																			|
       |	Returns:	string formattedJson										|
       |																			|
       |	Notes:	   Use this method to perform some basic housekeeping on        |
       |               JSON string before plunking them into a text box.  It will   |
       |               make the output easier on the eyes.                          |
       +----------------------------------------------------------------------------+															
       */
        private string FormatJSON(string unformattedJSON)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = unformattedJSON.ToCharArray();
            int len =chars.Length;
            int indent = 0;
            char last_char = ' ';
            bool new_line = true;
            for (int i = 0; i < len; i++)
            {
                if (chars[i] == '}')
                {
                    new_line = true;
                    sb.AppendLine();
                }
                else if (chars[i] == '{')
                {
                    if (i > 0)
                    {
                        sb.AppendLine();
                        for (int j = 0; j < indent; j++)
                        {
                            sb.Append(' ');
                        }
                    }
                }
                if (last_char == '}')
                {
                    indent -= 3;
                }
                if (last_char == '{')
                {
                    new_line = true;
                    sb.AppendLine();
                    indent += 3;
                }
                if (last_char == ',')
                {
                    sb.AppendLine();
                    new_line = true;
                }
                if (new_line)
                {
                    for (int j = 0; j < indent; j++)
                    {
                        sb.Append(' ');
                    }
                }
                sb.Append(chars[i]);
                new_line = false;
                last_char = chars[i];
            }
            return sb.ToString();
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	txtPostvars_Leave		                							    |
        |	=================          	    										|
        |																			|
        |	Inputs:		object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID            											|
        |																			|
        |	Notes:		Default event called when text box looses focus.            |
        |               Whenever the user modifies the XML post vars we will see    |
        |               if we can't pretty it up.                                   |
        +---------------------------------------------------------------------------+															
        */
        private void txtPostvars_Leave(object sender, EventArgs e)
        {
            if (txtPostvars.TextLength > 0) {
                String txt = "";
                if (getMode().Equals("XML"))
                {
                    txt = FormatXml(txtPostvars.Text);
                }
                else
                {
                    txt = FormatJSON(txtPostvars.Text);
                }
                txtPostvars.Text = txt;
            }
        }

        /*
        +---------------------------------------------------------------------------+
        |																			|
        |	cmbDropDown_SelectedIndexChanged           							    |
        |	================================  										|
        |																			|
        |	Inputs:		object sender (ignored)										|
        |               EventArgs e   (ignored)                                     |
        |																			|
        |	Returns:	VOID            											|
        |																			|
        |	Notes:		Anytime the mode changes from JSON to XML or vice-versa     |
        |               we should clear our text boxes.                             |
        +---------------------------------------------------------------------------+															
        */
        private void cmbDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndPoint.Text = "";
            txtPostvars.Text = "";
            txtResponse.Text = "";
        }

       /*
       +----------------------------------------------------------------------------+
       |																			|
       |	getMode                                    							    |
       |	=======  			                        							|
       |																			|
       |	Inputs:	    VOID							            				|
       |																			|
       |	Returns:	VOID            											|
       |																			|
       |	Notes:	    Determine if user is expecting XML or JSON                  |
       +----------------------------------------------------------------------------+															
       */
        private string getMode()
        {
            if (cmbDropDown.SelectedItem.ToString().Equals("XML Mode"))
            {
                return "XML";
            }
            else
            {
                return "JSON";
            }
        }

       /*
       +----------------------------------------------------------------------------+
       |																			|
       |	httpRequest                                							    |
       |	===========			                        							|
       |																			|
       |	Inputs:	    string verb 					            				|
       |																			|
       |	Returns:	VOID            											|
       |																			|
       |	Notes:	   Accept 'put', 'post', 'get', or delete from the caller and   |
       |               perform the appropriate HTTP communications with the SLAPI   |
       |               server.                                                      |
       +----------------------------------------------------------------------------+															
       */
        private void httpRequest(string verb)
        {
            try
            {
                string url = txtApiUrl.Text + @"/" + txtEndPoint.Text;
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                String authPair = txtUsername.Text + @":" + txtApiKey.Text;
                authPair = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authPair));
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
                req.Headers.Add("Authorization", "Basic " + authPair);
                req.Method = verb;
                if (getMode().Equals("XML"))
                {
                    req.ContentType = "text/json";
                }
                else
                {
                    req.ContentType = "text/xml";
                }
                if ((verb.Equals("post")) || (verb.Equals("put")))
                {
                    byte[] content = UTF8Encoding.UTF8.GetBytes(txtPostvars.Text.Trim());
                    req.ContentLength = content.Length;
                    using (Stream post = req.GetRequestStream())
                    {
                        post.Write(content, 0, content.Length);
                    }
                }
                string result = null;
                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
                if (getMode().Equals("XML"))
                {
                    txtResponse.Text = FormatXml(result);
                }
                else
                {
                    txtResponse.Text = FormatJSON(result);
                }
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message.ToString());
            }
        }

    }
}
