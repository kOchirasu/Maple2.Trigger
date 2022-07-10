using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000532_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004}, visible: true);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{7001, 7006, 7007}, visible: false);
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip();
                context.CreateMonster(spawnIds: new []{216, 101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 110, 111}, arg2: true);
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_8000");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_8001");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State목표(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{604, 603}, returnView: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "$02000532_BF__MAIN__0$", script: "$02000532_BF__MAIN__1$", align: Align.Center | Align.Right, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State목표(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목표 : TriggerState {
            internal State목표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.LockMyPc(isLock: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, script: "$02000532_BF__MAIN__2$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State문들어가기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문들어가기 : TriggerState {
            internal State문들어가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$02000532_BF__MAIN__3$", duration: 3000);
                context.SetEffect(triggerIds: new []{7006, 7007}, visible: true);
                context.CreateMonster(spawnIds: new []{408}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{408}, arg2: false)) {
                    return new State문이열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문이열림 : TriggerState {
            internal State문이열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3004}, visible: false);
                context.AddBalloonTalk(spawnId: 112, msg: "$02000532_BF__MAIN__4$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 112, msg: "$02000532_BF__MAIN__5$", duration: 3500, delayTick: 3500);
                context.AddBalloonTalk(spawnId: 102, msg: "$02000532_BF__MAIN__6$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 113, msg: "$02000532_BF__MAIN__7$", duration: 3500, delayTick: 900);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 10000f);
                context.SetNpcEmotionLoop(spawnId: 113, sequenceName: "Sit_Down_A", duration: 10000f);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Talk_A", duration: 10000f);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702}, jobCode: 0)) {
                    return new State경계하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경계하기 : TriggerState {
            internal State경계하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.LockMyPc(isLock: true);
                context.SetSceneSkip(state: new State흑성회의반격(context), arg2: "nextState");
                context.AddBalloonTalk(spawnId: 104, msg: "$02000532_BF__MAIN__8$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 105, msg: "$02000532_BF__MAIN__9$", duration: 3500, delayTick: 2500);
                context.AddBalloonTalk(spawnId: 103, msg: "$02000532_BF__MAIN__10$", duration: 3500, delayTick: 2800);
                context.SetEffect(triggerIds: new []{7006, 7007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State통신을받은제이부하(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통신을받은제이부하 : TriggerState {
            internal State통신을받은제이부하(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{602}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State통신을받은제이부하2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통신을받은제이부하2 : TriggerState {
            internal State통신을받은제이부하2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 205, msg: "$02000532_BF__MAIN__11$", duration: 3500, delayTick: 500);
                context.AddBalloonTalk(spawnId: 300, msg: "$02000532_BF__MAIN__12$", duration: 3500, delayTick: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State불안한제이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불안한제이 : TriggerState {
            internal State불안한제이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State불안한제이2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불안한제이2 : TriggerState {
            internal State불안한제이2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000532_BF__MAIN__13$");
                context.AddBalloonTalk(spawnId: 205, msg: "$02000532_BF__MAIN__14$", duration: 3500, delayTick: 4100);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State흑성회의반격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회의반격 : TriggerState {
            internal State흑성회의반격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(triggerIds: new []{3002, 3003}, visible: false);
                context.LockMyPc(isLock: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, script: "$02000532_BF__MAIN__15$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State흑성회의반격2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회의반격2 : TriggerState {
            internal State흑성회의반격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113});
                context.CreateMonster(spawnIds: new []{401, 402, 403, 404, 412, 405}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State흑성회의반격22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흑성회의반격22 : TriggerState {
            internal State흑성회의반격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 21450001, illust: "Mafia1_normal", duration: 3000, script: "$02000532_BF__MAIN__16$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State골목체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골목체크 : TriggerState {
            internal State골목체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 3000, script: "$02000532_BF__MAIN__17$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new State길목에서나오는Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길목에서나오는Monster : TriggerState {
            internal State길목에서나오는Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{108, 109});
                context.CreateMonster(spawnIds: new []{406, 407, 409, 410, 411}, arg2: true);
                context.AddBalloonTalk(spawnId: 409, msg: "$02000532_BF__MAIN__18$", duration: 3500, delayTick: 1500);
                context.AddBalloonTalk(spawnId: 410, msg: "$02000532_BF__MAIN__19$", duration: 3500, delayTick: 1500);
                context.AddBalloonTalk(spawnId: 407, msg: "$02000532_BF__MAIN__20$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{401, 402, 403, 404, 405, 406, 407, 409, 410, 411, 412})) {
                    return new State2차Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차Creation : TriggerState {
            internal State2차Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 3000, script: "$02000532_BF__MAIN__21$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State엘리베이터안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터안내 : TriggerState {
            internal State엘리베이터안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000532_BF__MAIN__22$", duration: 3000);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
