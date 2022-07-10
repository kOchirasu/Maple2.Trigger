using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000535_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{801, 802}, visible: false);
                context.SetMesh(triggerIds: new []{4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019}, visible: true);
                context.SetInteractObject(interactIds: new []{10003145, 10003146, 10003136, 10003137}, state: 0);
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
                context.CreateMonster(spawnIds: new []{5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 9902, 9903, 9904, 9905, 5500, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515, 5516, 5517, 5518, 5519, 5520, 5521, 506, 507, 508, 509, 510, 511, 512, 513, 519, 518, 517, 516, 515, 514, 670, 671, 5532}, arg2: true);
                context.MoveNpc(spawnId: 5532, patrolName: "MS2PatrolData_8000");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{5531}, arg2: true);
                context.AddBalloonTalk(spawnId: 5531, msg: "$02000535_BF__MAIN__0$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 5531, msg: "$02000535_BF__MAIN__1$", duration: 3500, delayTick: 3500);
                context.AddBalloonTalk(spawnId: 5523, msg: "$02000535_BF__MAIN__2$", duration: 3500, delayTick: 4500);
                context.AddBalloonTalk(spawnId: 5530, msg: "$02000535_BF__MAIN__3$", duration: 3500, delayTick: 1500);
                context.SetNpcEmotionLoop(spawnId: 5531, sequenceName: "Attack_Idle_A", duration: 7000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State첫번째전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째전투 : TriggerState {
            internal State첫번째전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531});
                context.CreateMonster(spawnIds: new []{523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{523, 524, 525, 526, 527, 528, 529, 530, 531})) {
                    return new StateNext으로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext으로이동 : TriggerState {
            internal StateNext으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003146}, state: 1);
                context.DestroyMonster(spawnIds: new []{523, 524, 525, 526, 527, 528, 529, 530, 531});
                context.AddBalloonTalk(spawnId: 0, msg: "$02000535_BF__MAIN__4$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706}, jobCode: 0)) {
                    return new State너무많아(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State너무많아 : TriggerState {
            internal State너무많아(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003146}, arg2: 0)) {
                    return new State머리를쓰자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State머리를쓰자 : TriggerState {
            internal State머리를쓰자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$02000535_BF__MAIN__5$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State바닥을보여주자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥을보여주자 : TriggerState {
            internal State바닥을보여주자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{802}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__6$", duration: 5000);
                context.SetInteractObject(interactIds: new []{10003136}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003136}, arg2: 0)) {
                    return new State타이밍맞추기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이밍맞추기1 : TriggerState {
            internal State타이밍맞추기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4000}, visible: false);
                context.SetInteractObject(interactIds: new []{10003136}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{709}, jobCode: 0)) {
                    return new State머리를쓰자2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State머리를쓰자2 : TriggerState {
            internal State머리를쓰자2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 5532, msg: "$02000535_BF__MAIN__7$", duration: 3500, delayTick: 300);
                context.AddBalloonTalk(spawnId: 5501, msg: "$02000535_BF__MAIN__8$", duration: 3500, delayTick: 800);
                context.AddBalloonTalk(spawnId: 5502, msg: "$02000535_BF__MAIN__9$", duration: 3500, delayTick: 800);
                context.AddBalloonTalk(spawnId: 5503, msg: "$02000535_BF__MAIN__10$", duration: 3500, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 5504, msg: "$02000535_BF__MAIN__11$", duration: 3500, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 5505, msg: "$02000535_BF__MAIN__12$", duration: 3500, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 5522, msg: "$02000535_BF__MAIN__13$", duration: 3500, delayTick: 300);
                context.AddBalloonTalk(spawnId: 5520, msg: "$02000535_BF__MAIN__14$", duration: 3500, delayTick: 300);
                context.AddBalloonTalk(spawnId: 5521, msg: "$02000535_BF__MAIN__15$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State통로이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통로이동1 : TriggerState {
            internal State통로이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 5520, msg: "$02000535_BF__MAIN__16$", duration: 5500, delayTick: 4500);
                context.AddBalloonTalk(spawnId: 5522, msg: "$02000535_BF__MAIN__17$", duration: 5500, delayTick: 7500);
                context.AddBalloonTalk(spawnId: 5505, msg: "$02000535_BF__MAIN__18$", duration: 5500, delayTick: 8500);
                context.AddBalloonTalk(spawnId: 5522, msg: "$02000535_BF__MAIN__19$", duration: 5500, delayTick: 12500);
                context.CreateMonster(spawnIds: new []{5000, 5001, 5002, 5003, 5004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702}, jobCode: 0)) {
                    return new State메이드대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메이드대사 : TriggerState {
            internal State메이드대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 670, msg: "$02000535_BF__MAIN__20$", duration: 3500, delayTick: 1500);
                context.AddBalloonTalk(spawnId: 671, msg: "$02000535_BF__MAIN__21$", duration: 3500);
                context.SetNpcEmotionLoop(spawnId: 670, sequenceName: "Attack_Idle_A", duration: 5000f);
                context.SetNpcEmotionLoop(spawnId: 671, sequenceName: "Attack_Idle_A", duration: 5000f);
                context.DestroyMonster(spawnIds: new []{5000, 5001, 5002, 5003, 5004});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State흑성회Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회Spawn : TriggerState {
            internal State흑성회Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{670, 671});
                context.CreateMonster(spawnIds: new []{601, 602, 603, 604, 605, 680, 681}, arg2: true);
                context.AddBalloonTalk(spawnId: 604, msg: "$02000535_BF__MAIN__22$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 602, msg: "$02000535_BF__MAIN__23$", duration: 3500, delayTick: 1500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602, 603, 604, 605, 680, 681})) {
                    return new State간부들엿보기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State간부들엿보기 : TriggerState {
            internal State간부들엿보기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new State간부들엿보기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State간부들엿보기2 : TriggerState {
            internal State간부들엿보기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "$02000535_BF__MAIN__24$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State간부들대화2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State간부들대화2 : TriggerState {
            internal State간부들대화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new StateCamera리셋시키기2(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{2005}, returnView: false);
                context.AddBalloonTalk(spawnId: 9902, msg: "$02000535_BF__MAIN__25$", duration: 3500);
                context.AddBalloonTalk(spawnId: 9903, msg: "$02000535_BF__MAIN__26$", duration: 3500, delayTick: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera리셋시키기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋시키기2 : TriggerState {
            internal StateCamera리셋시키기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
                context.LockMyPc(isLock: false);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__27$", duration: 5000);
                context.SetEffect(triggerIds: new []{801}, visible: true);
                context.SetInteractObject(interactIds: new []{10003137}, state: 1);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000535_BF__MAIN__28$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003137}, arg2: 0)) {
                    return new State통로오픈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통로오픈 : TriggerState {
            internal State통로오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4001}, visible: false);
                context.SideNpcTalk(npcId: 11004659, illust: "BreedMin_normal", duration: 4000, script: "$02000535_BF__MAIN__29$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State통로오픈2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통로오픈2 : TriggerState {
            internal State통로오픈2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004659, illust: "BreedMin_normal", duration: 4000, script: "$02000535_BF__MAIN__30$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{708}, jobCode: 0)) {
                    return new State테라스MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State테라스MonsterCreation : TriggerState {
            internal State테라스MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{606, 6606, 608, 6608}, arg2: true);
                context.AddBalloonTalk(spawnId: 606, msg: "$02000535_BF__MAIN__31$", duration: 5500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 608, msg: "$02000535_BF__MAIN__32$", duration: 5500, delayTick: 1500);
                context.SideNpcTalk(npcId: 11004660, illust: "Armand_normal", duration: 4000, script: "$02000535_BF__MAIN__33$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State테라스MonsterCreation2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State테라스MonsterCreation2 : TriggerState {
            internal State테라스MonsterCreation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004661, illust: "Kyle_normal", duration: 4000, script: "$02000535_BF__MAIN__34$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State테라스MonsterCreation3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State테라스MonsterCreation3 : TriggerState {
            internal State테라스MonsterCreation3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{607, 6607, 609, 610}, arg2: true);
                context.AddBalloonTalk(spawnId: 607, msg: "$02000535_BF__MAIN__35$", duration: 5500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 610, msg: "$02000535_BF__MAIN__36$", duration: 5500, delayTick: 2000);
                context.SideNpcTalk(npcId: 11004660, illust: "Armand_normal", duration: 4000, script: "$02000535_BF__MAIN__37$");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{606, 6606, 608, 6608, 607, 6607, 609, 610})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__38$", duration: 5000);
                context.SetMesh(triggerIds: new []{4019}, visible: false);
                context.SetInteractObject(interactIds: new []{10003145}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003145}, arg2: 0)) {
                    return new State보안게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보안게임시작 : TriggerState {
            internal State보안게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameLogicEnd", value: 999);
                context.WidgetAction(type: WidgetType.Round, name: "InitWidgetRound");
                context.SetUserValue(triggerId: 9002, key: "GameLogicStart", value: 999);
                context.LockMyPc(isLock: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State문열기시작2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기시작2 : TriggerState {
            internal State문열기시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__39$", duration: 4000);
                context.LockMyPc(isLock: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetUserValue(triggerId: 9002, key: "GameLogicStart", value: 1);
                    return new State게임로직종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임로직종료Wait : TriggerState {
            internal State게임로직종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GameLogicEnd") == 1) {
                    return new State게임로직종료및Success(context);
                }

                if (context.GetUserValue(key: "GameLogicEnd") == 2) {
                    return new State게임로직종료및실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및Success : TriggerState {
            internal State게임로직종료및Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new State게임로직종료(context);
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및실패 : TriggerState {
            internal State게임로직종료및실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new State실패게임로직종료(context);
            }

            public override void OnExit() { }
        }

        private class State게임로직종료 : TriggerState {
            internal State게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 3000f);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__40$", duration: 3000);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패게임로직종료 : TriggerState {
            internal State실패게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 3000f);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__41$", duration: 3000);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000535_BF__MAIN__42$", duration: 3500);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State문부시기안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문부시기안내 : TriggerState {
            internal State문부시기안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__43$", duration: 5000);
                context.LockMyPc(isLock: false);
                context.CreateMonster(spawnIds: new []{611}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{611})) {
                    return new State이동하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동하자 : TriggerState {
            internal State이동하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.LockMyPc(isLock: false);
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000535_BF__MAIN__44$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동하자2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동하자2 : TriggerState {
            internal State이동하자2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$02000535_BF__MAIN__45$", duration: 3500);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
