% % c=calculate(net1E0669,a')
% inputData=[0.3294	1.032	0.288	0.03	0.167	0.0262	0.0108	0.00215
% ]'
% load net1E0669 net inputps outputps
% 
% %% BP����Ԥ��
% %Ԥ�����ݹ�һ��
% inputn_test=mapminmax('apply',inputData,inputps);
% 
% %����Ԥ�����
% an=sim(net,inputn_test);
% 
%  
% %�����������һ��
% BPoutput=mapminmax('reverse',an,outputps)
% aaaa='net1E0669.mat'

% calculate(aaaa,inputData)
% calculate('net1E0669.mat',inputData)
Mycal=calculate('net1E0669',inputData)