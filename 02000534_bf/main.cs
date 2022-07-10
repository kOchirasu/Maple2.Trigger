namespace Maple2.Trigger._02000534_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008}, visible: true);
                context.SetEffect(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009}, visible: false);
                context.CreateMonster(spawnIds: new []{508, 509, 510, 511, 716, 715, 713, 717, 718, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712}, arg2: true);
                context.MoveNpc(spawnId: 508, patrolName: "MS2PatrolData_4000");
                context.MoveNpc(spawnId: 509, patrolName: "MS2PatrolData_4001");
                context.MoveNpc(spawnId: 511, patrolName: "MS2PatrolData_4002");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEventUI(arg1: 1, script: "$02000534_BF__MAIN__0$", duration: 3000);
                context.SetPortal(portalId: 2, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State첫번째Monster전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째Monster전투시작 : TriggerState {
            internal State첫번째Monster전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003132, 10003133, 10003134, 10003135}, state: 0);
                context.CreateMonster(spawnIds: new []{501, 520, 521, 522, 523}, arg2: true);
                context.AddBalloonTalk(spawnId: 523, msg: "$02000534_BF__MAIN__1$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 520, msg: "$02000534_BF__MAIN__2$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 521, msg: "$02000534_BF__MAIN__3$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{501, 520, 521, 522, 523})) {
                    return new State첫번째Monster처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째Monster처치 : TriggerState {
            internal State첫번째Monster처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetMesh(triggerIds: new []{7000}, visible: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__4$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707}, jobCode: 0)) {
                    return new State하렌Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌Spawn : TriggerState {
            internal State하렌Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000534_BF__MAIN__5$");
                context.CreateMonster(spawnIds: new []{502, 524, 525, 526, 527}, arg2: true, arg3: 100);
                context.AddBalloonTalk(spawnId: 502, msg: "$02000534_BF__MAIN__6$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 527, msg: "$02000534_BF__MAIN__7$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌Spawn2 : TriggerState {
            internal State하렌Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하렌Spawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌Spawn3 : TriggerState {
            internal State하렌Spawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000534_BF__MAIN__9$");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{502, 524, 525, 526, 527})) {
                    return new State두번째Monster처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Monster처치 : TriggerState {
            internal State두번째Monster처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8005}, visible: true);
                context.SetMesh(triggerIds: new []{7005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703}, jobCode: 0)) {
                    return new State첫번째연구실Monster정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째연구실Monster정리 : TriggerState {
            internal State첫번째연구실Monster정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 713, msg: "$02000534_BF__MAIN__10$", duration: 3500, delayTick: 2000);
                context.CreateMonster(spawnIds: new []{518, 519, 528}, arg2: true, arg3: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{518, 519, 528})) {
                    return new State오브젝트설명1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트설명1 : TriggerState {
            internal State오브젝트설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 713, msg: "$02000534_BF__MAIN__11$", duration: 3500, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State방해1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해1 : TriggerState {
            internal State방해1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__12$", duration: 3500, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State첫번째연구실나오기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째연구실나오기 : TriggerState {
            internal State첫번째연구실나오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7001}, visible: false);
                context.SetEffect(triggerIds: new []{8001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{708}, jobCode: 0)) {
                    return new State두번째전투판MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째전투판MonsterCreation : TriggerState {
            internal State두번째전투판MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{503, 529, 530, 531, 532}, arg2: true, arg3: 500);
                context.AddBalloonTalk(spawnId: 503, msg: "$02000534_BF__MAIN__13$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{503, 529, 530, 531, 532})) {
                    return new State두번째연구소이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구소이동 : TriggerState {
            internal State두번째연구소이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{714}, arg2: true);
                context.SetEffect(triggerIds: new []{8006}, visible: true);
                context.SetMesh(triggerIds: new []{7006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State두번째연구실Monster정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구실Monster정리 : TriggerState {
            internal State두번째연구실Monster정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 714, msg: "$02000534_BF__MAIN__14$", duration: 3500, delayTick: 500);
                context.MoveNpc(spawnId: 714, patrolName: "MS2PatrolData_4003");
                context.CreateMonster(spawnIds: new []{516, 517, 5516}, arg2: true, arg3: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{516, 517, 5516})) {
                    return new State두번째연구실Monster정리2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구실Monster정리2 : TriggerState {
            internal State두번째연구실Monster정리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{714});
                context.SetInteractObject(interactIds: new []{10003133}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003133}, arg2: 0)) {
                    return new State오브젝트설명2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트설명2 : TriggerState {
            internal State오브젝트설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003133}, state: 0);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__15$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State두번째연구실나오기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째연구실나오기 : TriggerState {
            internal State두번째연구실나오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__16$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세번째전투판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판 : TriggerState {
            internal State세번째전투판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7002}, visible: false);
                context.SetEffect(triggerIds: new []{8002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{709}, jobCode: 0)) {
                    return new State세번째전투판MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판MonsterCreation : TriggerState {
            internal State세번째전투판MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{504, 533}, arg2: true, arg3: 500);
                context.AddBalloonTalk(spawnId: 504, msg: "$02000534_BF__MAIN__17$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{504, 533})) {
                    return new State세번째Monster처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Monster처치 : TriggerState {
            internal State세번째Monster처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8007}, visible: true);
                context.SetMesh(triggerIds: new []{7007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new State세번째연구소이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째연구소이동 : TriggerState {
            internal State세번째연구소이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{514, 515}, arg2: false);
                context.AddBalloonTalk(spawnId: 718, msg: "$02000534_BF__MAIN__18$", duration: 3500);
                context.AddBalloonTalk(spawnId: 715, msg: "$02000534_BF__MAIN__19$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 715, msg: "$02000534_BF__MAIN__20$", duration: 3500, delayTick: 4000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{514, 515})) {
                    return new State방해3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해3 : TriggerState {
            internal State방해3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 717, msg: "$02000534_BF__MAIN__21$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State방해33(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해33 : TriggerState {
            internal State방해33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__22$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State네번째전투판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째전투판 : TriggerState {
            internal State네번째전투판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7003}, visible: false);
                context.SetEffect(triggerIds: new []{8003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{710}, jobCode: 0)) {
                    return new State네번째Monster처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째Monster처치 : TriggerState {
            internal State네번째Monster처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{505, 534, 535, 536, 537}, arg2: false);
                context.AddBalloonTalk(spawnId: 536, msg: "$02000534_BF__MAIN__23$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{505, 534, 535, 536, 537})) {
                    return new State네번째연구소로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째연구소로이동 : TriggerState {
            internal State네번째연구소로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8008}, visible: true);
                context.SetMesh(triggerIds: new []{7008}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706}, jobCode: 0)) {
                    return new State네번째연구소정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째연구소정리 : TriggerState {
            internal State네번째연구소정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{512, 513, 5513}, arg2: true);
                context.AddBalloonTalk(spawnId: 716, msg: "$02000534_BF__MAIN__24$", duration: 3500, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 716, msg: "$02000534_BF__MAIN__25$", duration: 3500, delayTick: 4500);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__26$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State컴퓨터조사하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State컴퓨터조사하기 : TriggerState {
            internal State컴퓨터조사하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000534_BF__MAIN__27$");
                context.AddBalloonTalk(spawnId: 716, msg: "$02000534_BF__MAIN__28$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{512, 513, 5513})) {
                    return new State4번연구실모두정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번연구실모두정리 : TriggerState {
            internal State4번연구실모두정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003135}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003135}, arg2: 0)) {
                    return new State오브젝트설명4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트설명4 : TriggerState {
            internal State오브젝트설명4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__29$", duration: 3000);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__30$", duration: 3500, delayTick: 3000);
                context.SetSceneSkip(state: new State방해4(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State방해4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해4 : TriggerState {
            internal State방해4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.RemoveBalloonTalk(spawnId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State방해44(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방해44 : TriggerState {
            internal State방해44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__31$");
                context.AddBalloonTalk(spawnId: 0, msg: "$02000534_BF__MAIN__32$", duration: 3500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막전투판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투판 : TriggerState {
            internal State마지막전투판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7004}, visible: false);
                context.SetEffect(triggerIds: new []{8004}, visible: true);
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
                context.SetMesh(triggerIds: new []{7004}, visible: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000534_BF__MAIN__33$");
                context.CreateMonster(spawnIds: new []{507}, arg2: true);
                context.AddBalloonTalk(spawnId: 507, msg: "$02000534_BF__MAIN__34$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 507) <= 0.50f) {
                    return new State업그레이드시작(context);
                }

                if (context.MonsterDead(spawnIds: new []{507})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업그레이드시작 : TriggerState {
            internal State업그레이드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15, display: true);
                context.CreateMonster(spawnIds: new []{9901, 9902, 9903, 9904}, arg2: false);
                context.AddBalloonTalk(spawnId: 507, msg: "$02000534_BF__MAIN__35$", duration: 3500, delayTick: 500);
                context.SetEventUI(arg1: 1, script: "$02000534_BF__MAIN__36$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State업그레이드Success체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State업그레이드Success체크 : TriggerState {
            internal State업그레이드Success체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State자폭스킬(context);
                }

                if (context.MonsterDead(spawnIds: new []{9901, 9902, 9903, 9904})) {
                    return new State실패(context);
                }

                if (context.MonsterDead(spawnIds: new []{507})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자폭스킬 : TriggerState {
            internal State자폭스킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 507, msg: "$02000534_BF__MAIN__37$", duration: 3500, delayTick: 500);
                context.SetAiExtraData(key: "bomb", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{507})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 507, msg: "$02000534_BF__MAIN__38$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{507})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15, display: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 3000, script: "$02000534_BF__MAIN__39$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePortalCreation2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation2 : TriggerState {
            internal StatePortalCreation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000534_BF__MAIN__40$", duration: 3000);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
