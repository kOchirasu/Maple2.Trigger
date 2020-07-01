using System;

namespace Maple2.Trigger._02000537_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5000}, arg2: true);
                context.SetMesh(arg1: new int[] {8900}, arg2: true);
                context.SetMesh(arg1: new int[] {8901}, arg2: true);
                context.SetMesh(arg1: new int[] {8902}, arg2: true);
                context.SetMesh(arg1: new int[] {8903}, arg2: true);
                context.SetMesh(arg1: new int[] {8904}, arg2: true);
                context.SetMesh(arg1: new int[] {8905}, arg2: true);
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetSkill(arg1: new int[] {9000}, arg2: false);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 3, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 4, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 5, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 6, isEnable: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {701}, arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000537_BF__MAIN__0$", arg3: new int[] {3000});
                context.CreateMonster(arg1: new int[] {101, 1011, 1012, 1013, 1014, 1017, 1018, 1019}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 1011, 1012, 1013, 1014, 1017, 1018, 1019})) {
                    context.State = new State도마뱀스폰1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도마뱀스폰1 : TriggerState {
            internal State도마뱀스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8900}, arg2: false);
                context.CreateMonster(arg1: new int[] {1015, 1016}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {702}, arg2: 0)) {
                    context.State = new State702시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State702시작 : TriggerState {
            internal State702시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
                context.CreateMonster(arg1: new int[] {102, 1022, 1023, 1024, 1025}, arg2: true);
                context.SideNpcTalk(npcID: 22600006, illust: "DesertDragonBigBlue_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__1$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102, 1022, 1023, 1024, 1025})) {
                    context.State = new State702마무리1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State702마무리1 : TriggerState {
            internal State702마무리1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8901}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State702마무리2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State702마무리2 : TriggerState {
            internal State702마무리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__2$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {703}, arg2: 0)) {
                    context.State = new State703시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703시작 : TriggerState {
            internal State703시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1026});
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State703진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703진행 : TriggerState {
            internal State703진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000537_BF__MAIN__3$", arg3: new int[] {3000});
                context.CreateMonster(arg1: new int[] {109}, arg2: true);
                context.CreateMonster(arg1: new int[] {103, 1031, 1032, 1033, 1034}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103, 1031, 1032, 1033, 1034})) {
                    context.State = new State703마무리1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703마무리1 : TriggerState {
            internal State703마무리1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8902}, arg2: false);
                context.CreateMonster(arg1: new int[] {1035}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State703마무리2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703마무리2 : TriggerState {
            internal State703마무리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__4$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {704}, arg2: 0)) {
                    context.State = new State704시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State704시작 : TriggerState {
            internal State704시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 3, isEnable: true);
                context.CreateMonster(arg1: new int[] {104, 1041, 1042, 1043, 1044}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State704진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State704진행 : TriggerState {
            internal State704진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__5$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {104, 1041, 1042, 1043, 1044})) {
                    context.State = new State704마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State704마무리 : TriggerState {
            internal State704마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8903}, arg2: false);
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__6$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {705}, arg2: 0)) {
                    context.State = new State705시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State705시작 : TriggerState {
            internal State705시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 3, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 4, isEnable: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State705진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State705진행 : TriggerState {
            internal State705진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {105, 1051, 1052, 1053, 1054}, arg2: true);
                context.SideNpcTalk(npcID: 22600006, illust: "DesertDragonBigBlue_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__7$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {105, 1051, 1052, 1053, 1054})) {
                    context.State = new State705마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State705마무리 : TriggerState {
            internal State705마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8904}, arg2: false);
                context.CreateMonster(arg1: new int[] {1036}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {708}, arg2: 0)) {
                    context.State = new State버프걸어주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프걸어주기 : TriggerState {
            internal State버프걸어주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__8$");
                context.SetSkill(arg1: new int[] {9000}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {706}, arg2: 0)) {
                    context.State = new State706시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State706시작 : TriggerState {
            internal State706시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__9$");
                context.EnableSpawnPointPc(spawnPointID: 4, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 5, isEnable: true);
                context.CreateMonster(arg1: new int[] {106, 1061, 1063, 1064, 1065}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {106, 1061, 1063, 1064, 1065})) {
                    context.State = new State706마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State706마무리 : TriggerState {
            internal State706마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8905}, arg2: false);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__10$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {707}, arg2: 0)) {
                    context.State = new State707시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State707시작 : TriggerState {
            internal State707시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 5, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 6, isEnable: true);
                context.CreateMonster(arg1: new int[] {108}, arg2: true);
                context.SideNpcTalk(npcID: 22600006, illust: "DesertDragonBigBlue_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__11$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {108})) {
                    context.State = new State포털생성전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성전 : TriggerState {
            internal State포털생성전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {109});
                context.CreateMonster(arg1: new int[] {1091}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포털생성전2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성전2 : TriggerState {
            internal State포털생성전2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {109});
                context.CreateMonster(arg1: new int[] {1091}, arg2: true);
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000537_BF__MAIN__12$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}