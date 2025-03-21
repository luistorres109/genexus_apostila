spec_i([ proc,0,'Load redundancy procedure','GXLRED',80,eng,'9_0_6-009' ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
rule_i(0,datastore(1,'DBMS',0)).
rule_i(0,datastore(1,'NAME','Default')).
rule_i(0,prop('NULLS_BEHAVIOR','CURRENT')).
rule_i(0,maingen(0)).
 
a_i(1,1,f,'Err',[],[ [],[ t('0',3) ] ]).
 
v_i(f,i,1,[]).
v_i(f,o,1,'Err').
 
 
 
 
 
attri_i('Errmsg',[ 'Gx_emsg',char,70,0,'',1,'Error text','',3 ]).
attri_i('Err',[ 'Gx_err',int,3,0,'ZZ9',1,'Error code','',2 ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
break_i(1,rpt,0,[],[ [],[],[] ]).
 
b_group_i(1,1,lit,0,1,0).
 
b_line_i(1,1,1,cmd,1,[ t('',105,1,0) ]).
 
 
 
 
page_layout_i([ 66,0,6 ]).
 
 
 
 
 
 
 
 
 
 
 
 
 
gen_reo_i.
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
