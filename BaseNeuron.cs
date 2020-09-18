using System;
using System.Collections.Generic;
using System.Text;
//using MathNet.Numerics.LinearAlgebra;
//using MathNet.Numerics.LinearAlgebra.Double;
namespace DistributedNeuron
{


    /// <summary>
    ///  涌动现象,记忆激活, 外部激活， 某些网络， 基因设定了已有的规则，
    /// 
    ///  皮层二维的分布, 主干网络三维结构
    /// 
    ///  脑主体: 
    ///  
    ///  外部主输入神经网络,(分布式传感器网络) 外部神经细胞的连接的权重更稳定
    ///  
    ///  初始神经元相互的连接会很对、等过发展一定阶段、神经元之间的流通逐渐稳定、流通权重很低的神经元逐渐断开,
    ///  
    ///  流通权重一值保持很高的神经元逐渐找到神经元的最短连通路径,建立新的连接
    ///  
    ///  神经源 之前的连接 w 值保证一定的随机性,
    ///  
    ///  构建类 内分泌神经的激素(多巴胺、内啡肽)奖励与衰减系统, 对于整体神经元 干涉调控
    ///  
    ///  基因设定的 大脑发育规则: 
    ///  
    ///  未被激活的神经网络, 连接权重趋于0 或逐渐断开，
    ///  
    ///  记忆编码系统, 固定现在被激活连接的权重,(局部 or 整体),记忆相关的蛋白应该是影响整体的记忆神经网络(两件不相干的事情同时活跃,记住其中一件事,另一间也会同时记住，记忆技巧)                    
    ///  
    ///  白天发生的事情，激活的不同区域的网络,与会相互连接,产生想关联的梦境
    ///  
    ///  神经细胞的生长与死亡,动态改变:
    ///  
    ///  神经细胞的分裂，(分裂而来的都接近母体的状态)
    ///  
    ///  神经干细跑的分化(分化而来的更接近与初始的神经细胞)
    /// 
    ///  神经的凋亡寿命:
    ///  
    ///  干细跑的 分化设计
    ///  
    /// 
    /// 
    /// </summary>

    class BaseNeuron
    {
        string id;     // 神经元的身份id() 

        float decline; // 影响此神经元全部连接权重的,衰退速度

        float life_time;     // 细胞的 剩余生命 随着时间衰减 每次分裂分生命回复 接近未分化时初始状态的生命

        float differentiation_time;  //分裂倒计时如果为0,神经细胞分裂

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
            //  当输出的权重值大于现有的权重值,对此输出的权重值激活正负增强（-1，1 区间内)
        }

        //固定帧更新
        public void Update()
        {
            //对于没有长时间激活的,神经源连接权重,随着时间与频率的推移回归平均值

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight">类似激素调控, 对神经元的 整体 w 进行激励放大，与惩罚减小</param>
        public void UpdateWeight(float weight)
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
        }


        /// <summary>
        /// 更新与记忆相关的蛋白表达强度,
        /// </summary>
        /// <param name="weight">固定网络</param>
        public void UpdateDecline(float weight)
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
            //更新计算
            decline = decline * weight;
        }



        /// <summary>
        /// 更新与生命相关的蛋白表达强度,
        /// </summary>
        /// <param name="weight">固定网络</param>
        public void UpdateLifeTime(float weight)
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
            //更新计算
            life_time = life_time * weight;
        }




        /// <summary>
        /// 更新与分裂的蛋白表达强度,
        /// </summary>
        /// <param name="weight">固定网络</param>
        public void UpdateDifferentiationTime(float weight)
        {
            //对于没有长时间激活的 神经源连接权重 随着时间与频率的推移回归平均值
            //更新计算
            differentiation_time = differentiation_time * weight;
        }

    }
}
