using System;

namespace Maple2.Trigger._02020100_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 3, isEnable: false);
                context.SetUserValue(triggerID: 99990002, key: "Seed1start", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "Seed2start", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "Seed3start", value: 0);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetLadder(arg1: 2001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2003, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2004, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2005, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2006, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2007, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(
                    arg1: new int[]
                        {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014},
                    arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(
                    arg1: new int[]
                        {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114},
                    arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(
                    arg1: new int[] {
                        1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216,
                        1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230
                    }, arg2: true, arg3: 0, arg4: 0);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1403, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1404, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new int[] {1301, 1302, 1303, 1304}, arg2: false, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new int[] {10002109}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002110}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002111}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002112}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002113}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002115}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002116}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002122}, arg2: 0);
                context.SetBreakable(arg1: new int[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009},
                    arg2: false);
                context.SetBreakable(arg1: new int[] {5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019},
                    arg2: false);
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetAgent(arg1: "9003", arg2: true);
                context.SetAgent(arg1: "9004", arg2: true);
                context.SetAgent(arg1: "9005", arg2: true);
                context.SetAgent(arg1: "9006", arg2: true);
                context.SetAgent(arg1: "9007", arg2: true);
                context.SetAgent(arg1: "9008", arg2: true);
                context.SetAgent(arg1: "9009", arg2: true);
                context.SetAgent(arg1: "9010", arg2: true);
                context.SetAgent(arg1: "9011", arg2: true);
                context.SetAgent(arg1: "9012", arg2: true);
                context.SetAgent(arg1: "9013", arg2: true);
                context.SetAgent(arg1: "9014", arg2: true);
                context.SetAgent(arg1: "9015", arg2: true);
                context.SetAgent(arg1: "9016", arg2: true);
                context.SetAgent(arg1: "9017", arg2: true);
                context.SetAgent(arg1: "9018", arg2: true);
                context.SetAgent(arg1: "9019", arg2: true);
                context.SetAgent(arg1: "9020", arg2: true);
                context.SetAgent(arg1: "9021", arg2: true);
                context.SetAgent(arg1: "9022", arg2: true);
                context.SetAgent(arg1: "9023", arg2: true);
                context.SetAgent(arg1: "9024", arg2: true);
                context.SetAgent(arg1: "9025", arg2: true);
                context.SetAgent(arg1: "9026", arg2: true);
                context.SetAgent(arg1: "9027", arg2: true);
                context.SetAgent(arg1: "9028", arg2: true);
                context.SetAgent(arg1: "9029", arg2: true);
                context.SetAgent(arg1: "9030", arg2: true);
                context.SetAgent(arg1: "9031", arg2: true);
                context.SetAgent(arg1: "9032", arg2: true);
                context.SetAgent(arg1: "9033", arg2: true);
                context.SetAgent(arg1: "9034", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {901})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetMesh(
                    arg1: new int[]
                        {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114},
                    arg2: false, arg3: 0, arg4: 0);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State씨앗체험(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗체험 : TriggerState {
            internal State씨앗체험(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
                context.SetAgent(arg1: "9008", arg2: false);
                context.SetAgent(arg1: "9009", arg2: false);
                context.SetMesh(arg1: new int[] {1007, 1008, 1009, 1010}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.CreateMonster(arg1: new int[] {202, 203, 204, 205}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {202, 203, 204, 205})) {
                    context.State = new State씨앗체험_씨앗들기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗체험_씨앗들기 : TriggerState {
            internal State씨앗체험_씨앗들기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020100_BF__MAIN__0$", arg3: new int[] {5000});
                context.SetUserValue(triggerID: 99990005, key: "Seed0start", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed0interact", value: 1)) {
                    context.State = new State씨앗체험_나무심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗체험_나무심기 : TriggerState {
            internal State씨앗체험_나무심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002116}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002116}, arg2: 0)) {
                    context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                    context.SetUserValue(triggerID: 99990005, key: "Seed0start", value: 2);
                    context.State = new State씨앗체험_끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗체험_끝 : TriggerState {
            internal State씨앗체험_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9010", arg2: false);
                context.SetAgent(arg1: "9011", arg2: false);
                context.SetAgent(arg1: "9012", arg2: false);
                context.SetAgent(arg1: "9013", arg2: false);
                context.SetMesh(arg1: new int[] {1011, 1012, 1013, 1014}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.CreateMonster(arg1: new int[] {207, 208, 209}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {207, 208, 209})) {
                    context.State = new State사다리활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리활성화 : TriggerState {
            internal State사다리활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 2001, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 2002, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 2003, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 2004, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 2005, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 2006, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 2007, arg2: true, arg3: true, arg4: 14);
                context.CreateMonster(arg1: new int[] {210, 211, 212}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {210, 211, 212})) {
                    context.State = new State씨앗1_활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗1_활성화 : TriggerState {
            internal State씨앗1_활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
                context.SetUserValue(triggerID: 99990002, key: "Seed1start", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed1interact", value: 1)) {
                    context.State = new State씨앗1_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗1_전투 : TriggerState {
            internal State씨앗1_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9014", arg2: false);
                context.SetAgent(arg1: "9015", arg2: false);
                context.SetAgent(arg1: "9016", arg2: false);
                context.SetAgent(arg1: "9017", arg2: false);
                context.SetAgent(arg1: "9018", arg2: false);
                context.CreateMonster(arg1: new int[] {213, 214, 215, 216}, arg2: false);
                context.SetMesh(arg1: new int[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210},
                    arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {213, 214, 215, 216})) {
                    context.State = new State씨앗1_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗1_심기 : TriggerState {
            internal State씨앗1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9019", arg2: false);
                context.SetAgent(arg1: "9020", arg2: false);
                context.SetAgent(arg1: "9021", arg2: false);
                context.SetAgent(arg1: "9022", arg2: false);
                context.SetMesh(arg1: new int[] {1001, 1002, 1003, 1004}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.SetInteractObject(arg1: new int[] {10002112}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002112}, arg2: 0)) {
                    context.State = new State씨앗2_활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗2_활성화 : TriggerState {
            internal State씨앗2_활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9023", arg2: false);
                context.SetAgent(arg1: "9024", arg2: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: true);
                context.SetUserValue(triggerID: 99990002, key: "Seed1start", value: 2);
                context.SetUserValue(triggerID: 99990003, key: "Seed2start", value: 1);
                context.SetMesh(arg1: new int[] {1005, 1006}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed2interact", value: 1)) {
                    context.State = new State씨앗2_전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗2_전투 : TriggerState {
            internal State씨앗2_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9025", arg2: false);
                context.SetAgent(arg1: "9026", arg2: false);
                context.SetAgent(arg1: "9027", arg2: false);
                context.SetAgent(arg1: "9028", arg2: false);
                context.SetAgent(arg1: "9029", arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02020100_BF__MAIN__1$", arg3: new int[] {5000});
                context.CreateMonster(arg1: new int[] {111, 112, 113, 114, 115, 116}, arg2: false);
                context.SetMesh(arg1: new int[] {1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220},
                    arg2: false, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new int[] {10002113}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002113}, arg2: 0)) {
                    context.State = new State발판1_지역감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판1_지역감지 : TriggerState {
            internal State발판1_지역감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9030", arg2: false);
                context.SetAgent(arg1: "9031", arg2: false);
                context.SetAgent(arg1: "9032", arg2: false);
                context.SetAgent(arg1: "9033", arg2: false);
                context.SetAgent(arg1: "9034", arg2: false);
                context.SetActor(arg1: 1403, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetMesh(arg1: new int[] {1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230},
                    arg2: false, arg3: 0, arg4: 0);
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 114, 115, 116});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {903})) {
                    context.State = new State발판1_활성화대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판1_활성화대기 : TriggerState {
            internal State발판1_활성화대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {225, 226}, arg2: false);
                context.SetUserValue(triggerID: 99990003, key: "Seed2start", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed3interact", value: 1)) {
                    context.State = new State발판1_몬스터처리(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {225, 226})) {
                    context.State = new State발판1_몬스터처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판1_몬스터처리 : TriggerState {
            internal State발판1_몬스터처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990004, key: "Seed3start", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Seed3interact", value: 1)) {
                    context.State = new State발판1_활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판1_활성화 : TriggerState {
            internal State발판1_활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002122}, arg2: 1);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 3, isEnable: true);
                context.CreateMonster(arg1: new int[] {121, 122, 123, 124}, arg2: false);
                context.SetBreakable(arg1: new int[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009},
                    arg2: true);
                context.SetBreakable(arg1: new int[] {5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019},
                    arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "EliteClear", value: 1)) {
                    context.State = new State보스전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전 : TriggerState {
            internal State보스전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990005, key: "Seed4start", value: 2);
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 114, 115, 116, 117, 118, 119});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}