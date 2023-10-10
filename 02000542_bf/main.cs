namespace Maple2.Trigger._02000542_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.EnableSpawnPointPc(spawnId: 0, enabled: true);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.SetInteractObject(interactIds: new []{10003142}, state: 1);
                context.SetInteractObject(interactIds: new []{10003143}, state: 0);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636}, visible: true);
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707}, jobCode: 0)) {
                    return new State문열기오브젝트설정1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기오브젝트설정1 : TriggerState {
            internal State문열기오브젝트설정1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000542_BF__MAIN__0$", duration: 5000);
                context.SetInteractObject(interactIds: new []{10003142}, state: 1);
                context.CreateMonster(spawnIds: new []{112}, arg2: false);
                context.AddBalloonTalk(spawnId: 112, msg: "$02000542_BF__MAIN__1$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003142}, arg2: 0)) {
                    return new State감옥문부시기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥문부시기1 : TriggerState {
            internal State감옥문부시기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000542_BF__MAIN__2$");
                context.DestroyMonster(spawnIds: new []{112});
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{609}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new StateMobCreation하기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation하기1 : TriggerState {
            internal StateMobCreation하기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State문을열자1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문을열자1 : TriggerState {
            internal State문을열자1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State감옥문부시기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥문부시기2 : TriggerState {
            internal State감옥문부시기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{605}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702}, jobCode: 0)) {
                    return new StateMobCreation하기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation하기2 : TriggerState {
            internal StateMobCreation하기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000542_BF__MAIN__3$");
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703}, jobCode: 0)) {
                    return new StateMobCreation하기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation하기3 : TriggerState {
            internal StateMobCreation하기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000542_BF__MAIN__4$");
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new StateMobCreation하기4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation하기4 : TriggerState {
            internal StateMobCreation하기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 103, 104})) {
                    return new State문열기오브젝트설정2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기오브젝트설정2 : TriggerState {
            internal State문열기오브젝트설정2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000542_BF__MAIN__5$", duration: 5000);
                context.SetInteractObject(interactIds: new []{10003143}, state: 1);
                context.CreateMonster(spawnIds: new []{113}, arg2: false);
                context.AddBalloonTalk(spawnId: 113, msg: "$02000542_BF__MAIN__6$", duration: 3500);
                context.AddBalloonTalk(spawnId: 113, msg: "$02000542_BF__MAIN__7$", duration: 3500, delayTick: 3500);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003143}, arg2: 0)) {
                    return new State감옥문부시기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥문부시기3 : TriggerState {
            internal State감옥문부시기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{604}, visible: false);
                context.DestroyMonster(spawnIds: new []{113});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{708}, jobCode: 0)) {
                    return new State감옥문부시기4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥문부시기4 : TriggerState {
            internal State감옥문부시기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{116}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{116})) {
                    return new State감옥문부시기5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥문부시기5 : TriggerState {
            internal State감옥문부시기5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{607}, visible: false);
                context.CreateMonster(spawnIds: new []{121}, arg2: false);
                context.AddBalloonTalk(spawnId: 121, msg: "$02000542_BF__MAIN__8$", duration: 8500, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{709}, jobCode: 0)) {
                    return new State감옥문부시기6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥문부시기6 : TriggerState {
            internal State감옥문부시기6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{121});
                context.SetMesh(triggerIds: new []{612}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new StateCinematicNPCSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicNPCSpawn : TriggerState {
            internal StateCinematicNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(spawnIds: new []{105, 111}, arg2: false);
                context.AddBalloonTalk(spawnId: 105, msg: "$02000542_BF__MAIN__9$", duration: 3500);
                context.AddBalloonTalk(spawnId: 105, msg: "$02000542_BF__MAIN__10$", duration: 4500, delayTick: 3500);
                context.AddBalloonTalk(spawnId: 111, msg: "$02000542_BF__MAIN__11$", duration: 3500, delayTick: 300);
                context.AddBalloonTalk(spawnId: 111, msg: "$02000542_BF__MAIN__12$", duration: 4500, delayTick: 3800);
                context.CreateMonster(spawnIds: new []{114}, arg2: false);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000542_BF__MAIN__13$");
                context.AddBalloonTalk(spawnId: 114, msg: "$02000542_BF__MAIN__14$", duration: 4500, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706}, jobCode: 0)) {
                    return new StateMonster다수Creation하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster다수Creation하기 : TriggerState {
            internal StateMonster다수Creation하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{114});
                context.EnableSpawnPointPc(spawnId: 0, enabled: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
                context.CreateMonster(spawnIds: new []{106, 107, 108, 109, 117, 118, 119, 120}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106, 107, 108, 109})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddBalloonTalk(spawnId: 117, msg: "$02000542_BF__MAIN__15$", duration: 8500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 118, msg: "$02000542_BF__MAIN__16$", duration: 8500, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 119, msg: "$02000542_BF__MAIN__17$", duration: 8500, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 120, msg: "$02000542_BF__MAIN__18$", duration: 8500, delayTick: 800);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000542_BF__MAIN__19$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn2 : TriggerState {
            internal StateBossSpawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{110})) {
                    return new StatePortal열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal열기 : TriggerState {
            internal StatePortal열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortal열기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal열기2 : TriggerState {
            internal StatePortal열기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{115}, arg2: false);
                context.DestroyMonster(spawnIds: new []{117, 118, 119, 120});
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000542_BF__MAIN__20$");
                context.AddBalloonTalk(spawnId: 115, msg: "$02000542_BF__MAIN__21$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePortal열기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal열기3 : TriggerState {
            internal StatePortal열기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetMesh(triggerIds: new []{601, 602}, visible: false);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{115});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
