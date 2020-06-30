using System;

namespace Maple2.Trigger._02000539_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetLadder(arg1: 601, arg2: false, arg3: false);
                context.SetLadder(arg1: 602, arg2: false, arg3: false);
                context.SetLadder(arg1: 603, arg2: false, arg3: false);
                context.SetLadder(arg1: 604, arg2: false, arg3: false);
                context.SetLadder(arg1: 605, arg2: false, arg3: false);
                context.SetLadder(arg1: 606, arg2: false, arg3: false);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 106, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(arg1: new int[] {904, 905, 906, 907, 908, 909}, arg2: true);
                context.SetMesh(
                    arg1: new int[]
                        {910, 911, 912, 913, 921, 914, 915, 922, 916, 917, 918, 919, 920, 923, 924, 925, 926, 927},
                    arg2: false);
                context.SetMesh(arg1: new int[] {928, 929, 930, 931, 932, 933, 934, 935, 936, 937}, arg2: false);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: false);
                context.SetSkill(arg1: new int[] {2000}, arg2: false);
                context.SetEffect(arg1: new int[] {3000}, arg2: false);
                context.SetEffect(arg1: new int[] {3001}, arg2: false);
                context.SetEffect(arg1: new int[] {3002}, arg2: false);
                context.SetEffect(arg1: new int[] {3003}, arg2: false);
                context.SetEffect(arg1: new int[] {3004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701", arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102})) {
                    context.State = new State잠시쉬기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기 : TriggerState {
            internal State잠시쉬기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "709", arg2: 0)) {
                    context.State = new State사다리생성하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성하기 : TriggerState {
            internal State사다리생성하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 601, arg2: true, arg3: true);
                context.SetLadder(arg1: 602, arg2: true, arg3: true);
                context.SetLadder(arg1: 603, arg2: true, arg3: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "706", arg2: 0)) {
                    context.State = new State잠시쉬기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기2 : TriggerState {
            internal State잠시쉬기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000539_BF__MAIN__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State잠시쉬기3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기3 : TriggerState {
            internal State잠시쉬기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {904, 905, 906, 907, 908, 909}, arg2: false);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "710", arg2: 0)) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {203});
                context.CreateMonster(arg1: new int[] {103, 1031, 1032, 1033, 1034}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103, 1031, 1032, 1033, 1034})) {
                    context.State = new State다음몬스터생성조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음몬스터생성조건체크 : TriggerState {
            internal State다음몬스터생성조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000539_BF__MAIN__1$");
                context.CreateMonster(arg1: new int[] {107, 1071, 1072}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다음몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음몬스터생성 : TriggerState {
            internal State다음몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {105, 1051, 1052}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {107, 1071, 1072, 105, 1051, 1052})) {
                    context.State = new StateNPC생성1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC생성1 : TriggerState {
            internal StateNPC생성1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__2$");
                context.SetEffect(arg1: new int[] {3000}, arg2: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "707", arg2: 0)) {
                    context.State = new StateNPC생성2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC생성2 : TriggerState {
            internal StateNPC생성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__3$");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_500");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State다리만들기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리만들기1 : TriggerState {
            internal State다리만들기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(arg1: new int[] {910, 911}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다리만들기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리만들기2 : TriggerState {
            internal State다리만들기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__4$");
                context.SetMesh(arg1: new int[] {912, 913, 921}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State다리만들기3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리만들기3 : TriggerState {
            internal State다리만들기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {914, 915, 922}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State다리만들기4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리만들기4 : TriggerState {
            internal State다리만들기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {916, 917, 918}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State다리만들기5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리만들기5 : TriggerState {
            internal State다리만들기5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {919, 920, 926, 922, 927}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State다리만들기6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리만들기6 : TriggerState {
            internal State다리만들기6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {923, 924, 925}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "708", arg2: 0)) {
                    context.State = new State다음몬스터생성1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음몬스터생성1 : TriggerState {
            internal State다음몬스터생성1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.CreateMonster(arg1: new int[] {111, 1111, 1112, 112, 1121}, arg2: true);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__5$");
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 1111, 1112, 112, 1121})) {
                    context.State = new State다음몬스터생성조건체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음몬스터생성조건체크2 : TriggerState {
            internal State다음몬스터생성조건체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__6$");
                context.CreateMonster(arg1: new int[] {113, 1131, 1132, 1133, 1134}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "705", arg2: 0)) {
                    context.State = new State다음몬스터생성조건체크3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음몬스터생성조건체크3 : TriggerState {
            internal State다음몬스터생성조건체크3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {113, 1131, 1132, 1133, 1134})) {
                    context.State = new State두번째다리만들기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째다리만들기1 : TriggerState {
            internal State두번째다리만들기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {204}, arg2: false);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__7$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "704", arg2: 0)) {
                    context.State = new State두번째다리만들기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째다리만들기2 : TriggerState {
            internal State두번째다리만들기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째사다리생성하기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째사다리생성하기1 : TriggerState {
            internal State두번째사다리생성하기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000539_BF__MAIN__8$");
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(arg1: new int[] {928, 929, 930, 931, 932, 933, 934, 935, 936, 937}, arg2: true);
                context.SetLadder(arg1: 604, arg2: true, arg3: true);
                context.SetLadder(arg1: 605, arg2: true, arg3: true);
                context.SetLadder(arg1: 606, arg2: true, arg3: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State다음몬스터생성3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음몬스터생성3 : TriggerState {
            internal State다음몬스터생성3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104, 1041}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {104, 1041})) {
                    context.State = new State보스문으로이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스문으로이동 : TriggerState {
            internal State보스문으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "711", arg2: 0)) {
                    context.State = new State벽부시기3단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽부시기3단계 : TriggerState {
            internal State벽부시기3단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 105, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(arg1: new int[] {938, 939, 940, 941, 942, 943}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702", arg2: 0)) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__9$");
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: true);
                context.CreateMonster(arg1: new int[] {119}, arg2: true);
                context.SetOnetimeEffect(id: 106, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스등장3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장3 : TriggerState {
            internal State보스등장3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3002}, arg2: true);
                context.SetEffect(arg1: new int[] {3003}, arg2: true);
                context.SetEffect(arg1: new int[] {3004}, arg2: true);
                context.SetSkill(arg1: new int[] {2000}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {119})) {
                    context.State = new State잠시쉬기4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기4 : TriggerState {
            internal State잠시쉬기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000539_BF__MAIN__10$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포탈활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈활성화 : TriggerState {
            internal State포탈활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}