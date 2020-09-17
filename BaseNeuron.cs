using System;
using System.Collections.Generic;
using System.Text;
//using MathNet.Numerics.LinearAlgebra;
//using MathNet.Numerics.LinearAlgebra.Double;
namespace DistributedNeuron
{

    /// <summary>
    ///  脑主体: 
    ///  外部主输入神经网络,(分布式传感器网络) 外部神经细胞的连接的权重更稳定
    ///  
    ///  初始神经元相互的连接会很对、等过发展一定阶段、神经元之间的流通逐渐稳定、流通权重很低的神经元逐渐断开,
    ///  流通权重一值保持很高的神经元逐渐找到神经元的最短连通路径,建立新的连接
    ///  神经源 之前的连接 w 值保证一定的随机性,
    ///  构建类 内分泌神经的激素(多巴胺、内啡肽)奖励与衰减系统, 对于整体神经元 干涉调控
    /// </summary>

    class BaseNeuron
    {
        string id;    // 神经元的身份id ()


        // 二维坐标空间的随机连接（）



        // 主连接、脉络连接、网连接( 神经元集合单元 从小单元到大单元、逐级增加)
        Dictionary<string, float> inputConnectedNeurons = new Dictionary<string, float>();  // 输入神经元的 id 与权重     （随机初始值大部分接近平均值 0）  
        Dictionary<string, float> outputConnectedNeurons = new Dictionary<string, float>();  // 输入神经元的 id 与权重    （随机初始值大部分接近平均值 0） 

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
        
        //固定帧更新
        public void Update()
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight">类似激素调控, 对神经元的 整体 w 进行激励放大，与惩罚减小</param>
        public void  UpdateWeight(float weight)
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
        }

    }
}
