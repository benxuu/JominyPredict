function [CResult] = calculate(ANNnet,inputData)
%#function network
load(ANNnet);
% net inputps outputps

%% BP����Ԥ��
%Ԥ�����ݹ�һ��
inputn_test=mapminmax('apply',inputData,inputps);

%����Ԥ�����
an=sim(net,inputn_test);

 
%�����������һ��
BPoutput=mapminmax('reverse',an,outputps);

%% ������
CResult=BPoutput;
end
