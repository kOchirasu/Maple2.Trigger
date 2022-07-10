namespace Maple2.Trigger._02000539_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetLadder(triggerId: 601, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 602, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 603, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 604, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 605, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 606, visible: false, animationEffect: false);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 106, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{904, 905, 906, 907, 908, 909}, visible: true);
                context.SetMesh(triggerIds: new []{910, 911, 912, 913, 921, 914, 915, 922, 916, 917, 918, 919, 920, 923, 924, 925, 926, 927, 928, 929, 930, 931, 932, 933, 934, 935, 936, 937}, visible: false);
                context.EnableSpawnPointPc(spawnId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 2, isEnable: false);
                context.SetSkill(triggerIds: new []{2000}, arg2: false);
                context.SetEffect(triggerIds: new []{3000, 3001, 3002, 3003, 3004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102})) {
                    return new State잠시쉬기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기 : TriggerState {
            internal State잠시쉬기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{709}, jobCode: 0)) {
                    return new StateLadderCreation하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation하기 : TriggerState {
            internal StateLadderCreation하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 601, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 602, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 603, visible: true, animationEffect: true);
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706}, jobCode: 0)) {
                    return new State잠시쉬기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기2 : TriggerState {
            internal State잠시쉬기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000539_BF__MAIN__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State잠시쉬기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기3 : TriggerState {
            internal State잠시쉬기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{904, 905, 906, 907, 908, 909}, visible: false);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{710}, jobCode: 0)) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{203});
                context.CreateMonster(spawnIds: new []{103, 1031, 1032, 1033, 1034}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103, 1031, 1032, 1033, 1034})) {
                    return new StateNextMonsterCreationConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMonsterCreationConditionCheck : TriggerState {
            internal StateNextMonsterCreationConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000539_BF__MAIN__1$");
                context.CreateMonster(spawnIds: new []{107, 1071, 1072}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNextMonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMonsterCreation : TriggerState {
            internal StateNextMonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105, 1051, 1052}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{107, 1071, 1072, 105, 1051, 1052})) {
                    return new StateNPCCreation1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation1 : TriggerState {
            internal StateNPCCreation1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000539_BF__MAIN__2$");
                context.SetEffect(triggerIds: new []{3000}, visible: true);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707}, jobCode: 0)) {
                    return new StateNPCCreation2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation2 : TriggerState {
            internal StateNPCCreation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000539_BF__MAIN__3$");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_500");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다리만들기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리만들기1 : TriggerState {
            internal State다리만들기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{910, 911}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State다리만들기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리만들기2 : TriggerState {
            internal State다리만들기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000539_BF__MAIN__4$");
                context.SetMesh(triggerIds: new []{912, 913, 921}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State다리만들기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리만들기3 : TriggerState {
            internal State다리만들기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{914, 915, 922}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State다리만들기4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리만들기4 : TriggerState {
            internal State다리만들기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{916, 917, 918}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State다리만들기5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리만들기5 : TriggerState {
            internal State다리만들기5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{919, 920, 926, 922, 927}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State다리만들기6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리만들기6 : TriggerState {
            internal State다리만들기6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{923, 924, 925}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{708}, jobCode: 0)) {
                    return new StateNextMonsterCreation1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMonsterCreation1 : TriggerState {
            internal StateNextMonsterCreation1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.CreateMonster(spawnIds: new []{111, 1111, 1112, 112, 1121}, arg2: true);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 3000, script: "$02000539_BF__MAIN__5$");
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 1, isEnable: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 1111, 1112, 112, 1121})) {
                    return new StateNextMonsterCreationConditionCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMonsterCreationConditionCheck2 : TriggerState {
            internal StateNextMonsterCreationConditionCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000539_BF__MAIN__6$");
                context.CreateMonster(spawnIds: new []{113, 1131, 1132, 1133, 1134}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new StateNextMonsterCreationConditionCheck3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMonsterCreationConditionCheck3 : TriggerState {
            internal StateNextMonsterCreationConditionCheck3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{3001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{113, 1131, 1132, 1133, 1134})) {
                    return new State두번째다리만들기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째다리만들기1 : TriggerState {
            internal State두번째다리만들기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204}, arg2: false);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 3000, script: "$02000539_BF__MAIN__7$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State두번째다리만들기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째다리만들기2 : TriggerState {
            internal State두번째다리만들기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째LadderCreation하기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째LadderCreation하기1 : TriggerState {
            internal State두번째LadderCreation하기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000539_BF__MAIN__8$");
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{928, 929, 930, 931, 932, 933, 934, 935, 936, 937}, visible: true);
                context.SetLadder(triggerId: 604, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 605, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 606, visible: true, animationEffect: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNextMonsterCreation3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMonsterCreation3 : TriggerState {
            internal StateNextMonsterCreation3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104, 1041}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{104, 1041})) {
                    return new StateBoss문으로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss문으로이동 : TriggerState {
            internal StateBoss문으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{711}, jobCode: 0)) {
                    return new State벽부시기3단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽부시기3단계 : TriggerState {
            internal State벽부시기3단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 105, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{938, 939, 940, 941, 942, 943}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702}, jobCode: 0)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 3000, script: "$02000539_BF__MAIN__9$");
                context.EnableSpawnPointPc(spawnId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 2, isEnable: true);
                context.CreateMonster(spawnIds: new []{119}, arg2: true);
                context.SetOnetimeEffect(id: 106, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn3 : TriggerState {
            internal StateBossSpawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{3002, 3003, 3004}, visible: true);
                context.SetSkill(triggerIds: new []{2000}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{119})) {
                    return new State잠시쉬기4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시쉬기4 : TriggerState {
            internal State잠시쉬기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000539_BF__MAIN__10$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
