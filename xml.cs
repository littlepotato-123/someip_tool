using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RWXxml
    {
        public void WriteXml(Dictionary<string, Service> main_dic, string fileName)
        {
            try
            {
                
                //首先 创建xml文档
                //1.实例化一个xmlDoucment类
                XmlDocument xDoc = new XmlDocument();
                //创建一个声明xml文档所需要语法的变量
                XmlDeclaration declaration = xDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                //将变量添加到xml文档末尾
                xDoc.AppendChild(declaration);
                //一个xml文档，必须要有一个根元素
                //创建根节点students
                XmlElement elem = xDoc.CreateElement("RootNode");
                //把根节点添加到xml文档中去
                xDoc.AppendChild(elem);
                string[] key = main_dic.Keys.ToArray<string>();

                for (int i = 0; i < main_dic.Count; i++)
                {

                    XmlElement xml_0 = xDoc.CreateElement("SeverviceName");
                    //把服务名给到每个Severvice Name节点属性
                    xml_0.SetAttribute("name", key[i]);
                    elem.AppendChild(xml_0);

                    XmlElement xml_1;
                    //处理Tag标签
                    foreach (string val in main_dic[key[i]].tag_)
                    {
                        xml_1 = xDoc.CreateElement("Tag");
                        xml_1.InnerText = val;
                        xml_0.AppendChild(xml_1);
                    }
                    //把服务ID给到每个Severvice ID节点属性
                    xml_1 = xDoc.CreateElement("SevivceID");
                    xml_1.InnerText = main_dic[key[i]].service_id_;
                    xml_0.AppendChild(xml_1);
                    //把服务描述给到每个SeviceDescription节点属性
                    xml_1 = xDoc.CreateElement("SeviceDescription");
                    xml_1.InnerText = main_dic[key[i]].server_description_;
                    xml_0.AppendChild(xml_1);

                    foreach (Dictionary<string, string> Port in main_dic[key[i]].Interface_)
                    {
                        string[] keyPort = Port.Keys.ToArray<string>();
                        xml_1 = xDoc.CreateElement("Interface_Name");
                        xml_1.SetAttribute("name", Port["Interface_Name"]);
                        xml_0.AppendChild(xml_1);
                        XmlElement xml_2;
                        for (int j = 0; j < keyPort.Count() - 1; j++)
                        {
                            if (keyPort[j] == "Interface_Name")
                            {
                                continue;
                            }
                            xml_2 = xDoc.CreateElement(keyPort[j]);
                            xml_2.InnerText = Port[keyPort[j]];
                            xml_1.AppendChild(xml_2);
                        }
                    }
                }

                xDoc.Save(fileName);
            }
            catch 
            {
                MessageBox.Show("保存失败", "提醒");
                return;
            }
            MessageBox.Show("保存成功", "提醒");
        }

        public Dictionary<string, Service> ReadXml(string path)
        {
            //创建新对象保存加载的数据
            Dictionary<string, Service> Read_dic = new Dictionary<string, Service>();

            try
            {
                //创建xml对象
                XmlDocument xDoc = new XmlDocument();
                //加载指定路径的文件
                xDoc.Load(path);
                //获取xml文件的根节点
                XmlNode rootnode = xDoc.DocumentElement;
                //获取所有根节点下的所有一级节点 （rootnode对象的所有子节点）
                XmlNodeList nodeList = rootnode.ChildNodes;
                //遍历所有一级节点，一级数表明服务数
                foreach (XmlNode node_0 in nodeList)
                {
                    //int cur_row = 0;
                    //类型显示转换，使xml节点对象变为可读对象
                    XmlElement Rnode_0 = (XmlElement)node_0;
                    //获取一级节点下的所有二级节点， 即每个服务下的service类
                    XmlNodeList Severvice = node_0.ChildNodes;
                    //添加当前键值
                    Read_dic.Add(Rnode_0.GetAttribute("name"), new Service(Rnode_0.GetAttribute("name"),0));
                    //遍历所有二级节点，二级节点表明service类的每一项数据
                    foreach (XmlNode node_1 in Severvice)
                    {
                        //类型显示转换，使xml节点对象变为可读对象
                        XmlElement Rnode_1 = (XmlElement)node_1;
                        
                        //根据二级节点的限定名来为对应service类变量赋值
                        if (Rnode_1.Name == "SevivceID")
                        {
                            Read_dic[Rnode_0.GetAttribute("name")].service_id_ = Rnode_1.InnerText;
                        }
                        else if (Rnode_1.Name == "SeviceDescription")
                        {
                            Read_dic[Rnode_0.GetAttribute("name")].server_description_ = Rnode_1.InnerText;
                        }

                        else if (Rnode_1.Name == "Tag") 
                        {
                            Read_dic[Rnode_0.GetAttribute("name")].tag_.Add(Rnode_1.InnerText.ToString());       
                        }
                        //二级节点限定名为PRC_Type时跳入
                        else
                        {
                            //获取限定名为PRC_Type的二级节点的所有子节点 也即三级节点
                            XmlNodeList PRC_Type = node_1.ChildNodes;

                            //创建个字典用来存放所有PRC_Type类型下的数据
                            Dictionary<string, string> PRC_Type_info = new Dictionary<string, string>();
                            PRC_Type_info.Add(Rnode_1.Name, Rnode_1.GetAttribute("name"));
                            //遍历三级节点所有值
                            foreach (XmlNode node_2 in PRC_Type)
                            {
                                //把所有PRC_Type类型下的数据赋值给PRC_Type_info字典
                                XmlElement Rnode_2 = (XmlElement)node_2;
                                PRC_Type_info.Add(Rnode_2.Name, Rnode_2.InnerText);
                            }
                            //把存放PRC_Type数据的字典放在Read_dic下
                            Read_dic[Rnode_0.GetAttribute("name")].Interface_.Add(PRC_Type_info);
                        }
                    }
                    //把当前服务含有的接口数赋值给Read_dic字典
                }


            }
            catch
            {
                MessageBox.Show("加载文件出错", "提醒");
            }
            return Read_dic;
        }
    }

    
}

