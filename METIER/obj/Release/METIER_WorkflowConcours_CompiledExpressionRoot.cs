namespace METIER {
    
    #line 16 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 17 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 18 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 19 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 20 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 21 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using METIER;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Jérémy\Google Drive\VS\ConcoursDePalets\IHM\METIER\WorkflowConcours.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class WorkflowConcours : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = WorkflowConcours_TypedDataContext4_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext0 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext1 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext2 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext3 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext4 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WorkflowConcours_TypedDataContext4(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4 refDataContext5 = ((WorkflowConcours_TypedDataContext4)(cachedCompiledDataContext[1]));
                return refDataContext5.GetLocation<METIER.Equipe>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext6 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext7 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WorkflowConcours_TypedDataContext4(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4 refDataContext8 = ((WorkflowConcours_TypedDataContext4)(cachedCompiledDataContext[1]));
                return refDataContext8.GetLocation<System.Collections.Generic.List<int>>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext9 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WorkflowConcours_TypedDataContext4(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4 refDataContext10 = ((WorkflowConcours_TypedDataContext4)(cachedCompiledDataContext[1]));
                return refDataContext10.GetLocation<int>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext11 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WorkflowConcours_TypedDataContext4(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4 refDataContext12 = ((WorkflowConcours_TypedDataContext4)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<int>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext13 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext14 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext15 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WorkflowConcours_TypedDataContext4(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4 refDataContext16 = ((WorkflowConcours_TypedDataContext4)(cachedCompiledDataContext[1]));
                return refDataContext16.GetLocation<bool>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WorkflowConcours_TypedDataContext4(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4 refDataContext17 = ((WorkflowConcours_TypedDataContext4)(cachedCompiledDataContext[1]));
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext18 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext19 = ((WorkflowConcours_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new WorkflowConcours_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext5_ForReadOnly valDataContext20 = ((WorkflowConcours_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new WorkflowConcours_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext5_ForReadOnly valDataContext21 = ((WorkflowConcours_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext22 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext23 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext24 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext25 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new WorkflowConcours_TypedDataContext7(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext7 refDataContext26 = ((WorkflowConcours_TypedDataContext7)(cachedCompiledDataContext[4]));
                return refDataContext26.GetLocation<System.Collections.Generic.List<int>>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext27 = ((WorkflowConcours_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext28 = ((WorkflowConcours_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext29 = ((WorkflowConcours_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext30 = ((WorkflowConcours_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext31 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext32 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext33 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext34 = ((WorkflowConcours_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext35 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext36 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext37 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext38 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext39 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext40 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext41 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WorkflowConcours_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext42 = ((WorkflowConcours_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext42.ValueType___Expr42Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext0 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext1 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext2 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext3 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext4 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                WorkflowConcours_TypedDataContext4 refDataContext5 = new WorkflowConcours_TypedDataContext4(locations, true);
                return refDataContext5.GetLocation<METIER.Equipe>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext6 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext7 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                WorkflowConcours_TypedDataContext4 refDataContext8 = new WorkflowConcours_TypedDataContext4(locations, true);
                return refDataContext8.GetLocation<System.Collections.Generic.List<int>>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext9 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                WorkflowConcours_TypedDataContext4 refDataContext10 = new WorkflowConcours_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<int>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext11 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                WorkflowConcours_TypedDataContext4 refDataContext12 = new WorkflowConcours_TypedDataContext4(locations, true);
                return refDataContext12.GetLocation<int>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext13 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext14 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext15 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                WorkflowConcours_TypedDataContext4 refDataContext16 = new WorkflowConcours_TypedDataContext4(locations, true);
                return refDataContext16.GetLocation<bool>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                WorkflowConcours_TypedDataContext4 refDataContext17 = new WorkflowConcours_TypedDataContext4(locations, true);
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext18 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                WorkflowConcours_TypedDataContext4_ForReadOnly valDataContext19 = new WorkflowConcours_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                WorkflowConcours_TypedDataContext5_ForReadOnly valDataContext20 = new WorkflowConcours_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                WorkflowConcours_TypedDataContext5_ForReadOnly valDataContext21 = new WorkflowConcours_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext22 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext23 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext24 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext25 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                WorkflowConcours_TypedDataContext7 refDataContext26 = new WorkflowConcours_TypedDataContext7(locations, true);
                return refDataContext26.GetLocation<System.Collections.Generic.List<int>>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext27 = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext28 = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext29 = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                WorkflowConcours_TypedDataContext7_ForReadOnly valDataContext30 = new WorkflowConcours_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext31 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext32 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext33 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                WorkflowConcours_TypedDataContext6_ForReadOnly valDataContext34 = new WorkflowConcours_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext35 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext36 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext37 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext38 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext39 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext40 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext41 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                WorkflowConcours_TypedDataContext8_ForReadOnly valDataContext42 = new WorkflowConcours_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext42.ValueType___Expr42Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "WorkflowState.Config") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Vues.Configuration") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!Suivant") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Equipe") 
                        && (WorkflowConcours_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Equipe") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Config") 
                        && (WorkflowConcours_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Config[1]") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NbMatchsAleatoires") 
                        && (WorkflowConcours_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Config[2]") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NbMatchsClassement") 
                        && (WorkflowConcours_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Config[2]") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Config[1]") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Suivant") 
                        && (WorkflowConcours_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "EquipeDeleted") 
                        && (WorkflowConcours_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "EquipeDeleted") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Vues.Classement") 
                        && (WorkflowConcours_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowState.Match") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours().GetCurrentManche()") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!Concours.GetCurrentConcours().GetCurrentManche().AreAllMatchsDone();") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Score") 
                        && (WorkflowConcours_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Score[2]") 
                        && (WorkflowConcours_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Score[1]") 
                        && (WorkflowConcours_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours().GetCurrentManche()") 
                        && (WorkflowConcours_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Score[0]") 
                        && (WorkflowConcours_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours().GetCurrentManche()") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours().GetCurrentManche()") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours().Manches.Count < (NbMatchsAleatoires + NbMatchsClass" +
                            "ement)") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "!(Concours.GetCurrentConcours().Manches.Count < (NbMatchsAleatoires + NbMatchsCla" +
                            "ssement))") 
                        && (WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WorkflowState.TirageMatchsSuivants") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours().Manches.Count<NbMatchsAleatoires") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Vues.Match") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Concours.GetCurrentConcours()") 
                        && (WorkflowConcours_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new WorkflowConcours_TypedDataContext4(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new WorkflowConcours_TypedDataContext4(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new WorkflowConcours_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new WorkflowConcours_TypedDataContext4(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new WorkflowConcours_TypedDataContext4(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new WorkflowConcours_TypedDataContext4(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new WorkflowConcours_TypedDataContext4_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new WorkflowConcours_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new WorkflowConcours_TypedDataContext5_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new WorkflowConcours_TypedDataContext7(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new WorkflowConcours_TypedDataContext7_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new WorkflowConcours_TypedDataContext7_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new WorkflowConcours_TypedDataContext7_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new WorkflowConcours_TypedDataContext7_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new WorkflowConcours_TypedDataContext6_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new WorkflowConcours_TypedDataContext8_ForReadOnly(locationReferences).@__Expr42GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext1 : WorkflowConcours_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return WorkflowConcours_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext1_ForReadOnly : WorkflowConcours_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return WorkflowConcours_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext2 : WorkflowConcours_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int NbMatchsAleatoires;
            
            protected int NbMatchsClassement;
            
            public WorkflowConcours_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.NbMatchsAleatoires = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.NbMatchsClassement = ((int)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.NbMatchsAleatoires);
                this.SetVariableValue((1 + locationsOffset), this.NbMatchsClassement);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "NbMatchsAleatoires") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "NbMatchsClassement") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                return WorkflowConcours_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext2_ForReadOnly : WorkflowConcours_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int NbMatchsAleatoires;
            
            protected int NbMatchsClassement;
            
            public WorkflowConcours_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.NbMatchsAleatoires = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.NbMatchsClassement = ((int)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "NbMatchsAleatoires") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "NbMatchsClassement") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                return WorkflowConcours_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext3 : WorkflowConcours_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext3_ForReadOnly : WorkflowConcours_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext4 : WorkflowConcours_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool Suivant;
            
            public WorkflowConcours_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.List<int> Config {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected METIER.Equipe Equipe {
                get {
                    return ((METIER.Equipe)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string EquipeDeleted {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 91 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Equipe>> expression = () => 
                            Equipe;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Equipe @__Expr5Get() {
                
                #line 91 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Equipe;
                
                #line default
                #line hidden
            }
            
            public METIER.Equipe ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(METIER.Equipe value) {
                
                #line 91 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                            Equipe = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(METIER.Equipe value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 114 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<int>>> expression = () => 
                            Config;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<int> @__Expr8Get() {
                
                #line 114 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Config;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<int> ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(System.Collections.Generic.List<int> value) {
                
                #line 114 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                            Config = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(System.Collections.Generic.List<int> value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 123 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            NbMatchsAleatoires;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr10Get() {
                
                #line 123 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            NbMatchsAleatoires;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(int value) {
                
                #line 123 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                            NbMatchsAleatoires = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 135 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            NbMatchsClassement;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr12Get() {
                
                #line 135 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            NbMatchsClassement;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(int value) {
                
                #line 135 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                            NbMatchsClassement = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 160 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Suivant;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr16Get() {
                
                #line 160 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Suivant;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(bool value) {
                
                #line 160 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                            Suivant = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 174 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            EquipeDeleted;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 174 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            EquipeDeleted;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(string value) {
                
                #line 174 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                            EquipeDeleted = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Suivant = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.Suivant);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 2)].Name != "Config") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Equipe") 
                            || (locationReferences[(offset + 3)].Type != typeof(METIER.Equipe)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "EquipeDeleted") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Suivant") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return WorkflowConcours_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext4_ForReadOnly : WorkflowConcours_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool Suivant;
            
            public WorkflowConcours_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.List<int> Config {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected METIER.Equipe Equipe {
                get {
                    return ((METIER.Equipe)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string EquipeDeleted {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 65 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<WorkflowState>> expression = () => 
                WorkflowState.Config;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public WorkflowState @__Expr0Get() {
                
                #line 65 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                WorkflowState.Config;
                
                #line default
                #line hidden
            }
            
            public WorkflowState ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 61 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                  Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr1Get() {
                
                #line 61 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                  Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 76 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<Vues>> expression = () => 
                Vues.Configuration;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Vues @__Expr2Get() {
                
                #line 76 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                Vues.Configuration;
                
                #line default
                #line hidden
            }
            
            public Vues ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 72 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                  Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr3Get() {
                
                #line 72 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                  Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 81 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                !Suivant;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 81 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                !Suivant;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 104 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Equipe>> expression = () => 
                          Equipe;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Equipe @__Expr6Get() {
                
                #line 104 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Equipe;
                
                #line default
                #line hidden
            }
            
            public METIER.Equipe ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 100 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                            Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr7Get() {
                
                #line 100 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 128 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            Config[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr9Get() {
                
                #line 128 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Config[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 140 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            Config[2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr11Get() {
                
                #line 140 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Config[2];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 154 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                          Config[2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr13Get() {
                
                #line 154 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Config[2];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 147 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                            Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr14Get() {
                
                #line 147 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                            Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 151 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                          Config[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 151 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Config[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 186 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        EquipeDeleted;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 186 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                        EquipeDeleted;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 182 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr19Get() {
                
                #line 182 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Suivant = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 2)].Name != "Config") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Equipe") 
                            || (locationReferences[(offset + 3)].Type != typeof(METIER.Equipe)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "EquipeDeleted") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Suivant") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return WorkflowConcours_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext5 : WorkflowConcours_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext5_ForReadOnly : WorkflowConcours_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 382 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<Vues>> expression = () => 
                                      Vues.Classement;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Vues @__Expr20Get() {
                
                #line 382 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                      Vues.Classement;
                
                #line default
                #line hidden
            }
            
            public Vues ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 378 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                                        Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr21Get() {
                
                #line 378 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                        Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext6 : WorkflowConcours_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext6_ForReadOnly : WorkflowConcours_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 280 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<WorkflowState>> expression = () => 
                                WorkflowState.Match;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public WorkflowState @__Expr22Get() {
                
                #line 280 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                WorkflowState.Match;
                
                #line default
                #line hidden
            }
            
            public WorkflowState ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 276 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                                  Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr23Get() {
                
                #line 276 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                  Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 286 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Manche>> expression = () => 
                                  Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Manche @__Expr24Get() {
                
                #line 286 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                  Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
            }
            
            public METIER.Manche ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 292 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                !Concours.GetCurrentConcours().GetCurrentManche().AreAllMatchsDone();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr25Get() {
                
                #line 292 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                !Concours.GetCurrentConcours().GetCurrentManche().AreAllMatchsDone();;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 336 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Manche>> expression = () => 
                                  Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Manche @__Expr31Get() {
                
                #line 336 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                  Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
            }
            
            public METIER.Manche ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 349 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Manche>> expression = () => 
                                  Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Manche @__Expr32Get() {
                
                #line 349 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                  Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
            }
            
            public METIER.Manche ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 365 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Concours.GetCurrentConcours().Manches.Count < (NbMatchsAleatoires + NbMatchsClassement);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 365 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                              Concours.GetCurrentConcours().Manches.Count < (NbMatchsAleatoires + NbMatchsClassement);
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 370 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              !(Concours.GetCurrentConcours().Manches.Count < (NbMatchsAleatoires + NbMatchsClassement));
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr34Get() {
                
                #line 370 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                              !(Concours.GetCurrentConcours().Manches.Count < (NbMatchsAleatoires + NbMatchsClassement));
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext7 : WorkflowConcours_TypedDataContext6 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.List<int> Score {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 305 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<int>>> expression = () => 
                                            Score;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<int> @__Expr26Get() {
                
                #line 305 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                            Score;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<int> ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(System.Collections.Generic.List<int> value) {
                
                #line 305 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                
                                            Score = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(System.Collections.Generic.List<int> value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "Score") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                return WorkflowConcours_TypedDataContext6.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext7_ForReadOnly : WorkflowConcours_TypedDataContext6_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Collections.Generic.List<int> Score {
                get {
                    return ((System.Collections.Generic.List<int>)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 324 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                          Score[2];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr27Get() {
                
                #line 324 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                          Score[2];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 321 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                          Score[1];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr28Get() {
                
                #line 321 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                          Score[1];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 314 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Manche>> expression = () => 
                                            Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Manche @__Expr29Get() {
                
                #line 314 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                            Concours.GetCurrentConcours().GetCurrentManche();
                
                #line default
                #line hidden
            }
            
            public METIER.Manche ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 318 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                          Score[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr30Get() {
                
                #line 318 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                                          Score[0];
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "Score") 
                            || (locationReferences[(offset + 2)].Type != typeof(System.Collections.Generic.List<int>)))) {
                    return false;
                }
                return WorkflowConcours_TypedDataContext6_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext8 : WorkflowConcours_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WorkflowConcours_TypedDataContext8_ForReadOnly : WorkflowConcours_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WorkflowConcours_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WorkflowConcours_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 212 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<WorkflowState>> expression = () => 
                        WorkflowState.TirageMatchsSuivants;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public WorkflowState @__Expr35Get() {
                
                #line 212 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                        WorkflowState.TirageMatchsSuivants;
                
                #line default
                #line hidden
            }
            
            public WorkflowState ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 208 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr36Get() {
                
                #line 208 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 219 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Concours.GetCurrentConcours().Manches.Count<NbMatchsAleatoires;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr37Get() {
                
                #line 219 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Concours.GetCurrentConcours().Manches.Count<NbMatchsAleatoires;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 226 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                              Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr38Get() {
                
                #line 226 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                              Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 235 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                              Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr39Get() {
                
                #line 235 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                              Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 248 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<Vues>> expression = () => 
                        Vues.Match;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Vues @__Expr40Get() {
                
                #line 248 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                        Vues.Match;
                
                #line default
                #line hidden
            }
            
            public Vues ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 244 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr41Get() {
                
                #line 244 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 257 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                System.Linq.Expressions.Expression<System.Func<METIER.Concours>> expression = () => 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public METIER.Concours @__Expr42Get() {
                
                #line 257 "C:\USERS\JÉRÉMY\GOOGLE DRIVE\VS\CONCOURSDEPALETS\IHM\METIER\WORKFLOWCONCOURS.XAML"
                return 
                          Concours.GetCurrentConcours();
                
                #line default
                #line hidden
            }
            
            public METIER.Concours ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WorkflowConcours_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
