using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
namespace DistributedNeuron
{

    /// <summary>
    ///  脑主体: 
    ///  外部主输入神经网络,(分布式传感器网络) 外部神经细胞的连接的权重更稳定
    /// </summary>

    class BaseNeuron
    {
        string id;    // 神经元的身份id ()


        // 二维坐标空间的随机连接（）



        // 主连接、脉络连接、网连接( 神经元集合单元 从小单元到大单元、逐级增加)
        Dictionary<string, double> inputConnectedNeurons = new Dictionary<string, double>();  // 输入神经元的 id 与权重     （随机初始值大部分接近平均值 0）  
        Dictionary<string, double> outputConnectedNeurons = new Dictionary<string, double>();  // 输入神经元的 id 与权重    （随机初始值大部分接近平均值 0） 

        public BaseNeuron()
        {
            id = Guid.NewGuid().ToString("N");

            // 随机分配输入相连的神经元   <形成网络结构>
            // 随机分配输出相连的神经元   <与输出神经元有一定比例的重合>


            //inputConnectedNeurons       随机赋值
            //outputConnectedNeurons      随机赋值


        }


        // 输入神经元
        public void Input(BaseNeuron baseNeuron)
        {
            // 当输入的权重值大于现有的权重值,对此输入的权重值激活正负增强（-1，1 区间内） 

        }

        // 输入神经元
        public void Output(BaseNeuron baseNeuron)
        {
            //  当输出的权重值大于现有的权重值,对此输出的权重值激活正负增强（-1，1 区间内） 
        }
        // 输入神经元
        public void Update()
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
        }

    }
}
