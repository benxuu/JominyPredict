function [CResult] = calculate(ANNnet,inputData)
%#function network
load(ANNnet);
% net inputps outputps

%% BP网络预测
%预测数据归一化
inputn_test=mapminmax('apply',inputData,inputps);

%网络预测输出
an=sim(net,inputn_test);

 
%网络输出反归一化
BPoutput=mapminmax('reverse',an,outputps);

%% 结果输出
CResult=BPoutput;
end
