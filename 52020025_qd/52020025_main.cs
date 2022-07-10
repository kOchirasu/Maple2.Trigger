namespace Maple2.Trigger._52020025_qd {
    public static class _52020025_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001}, visible: true);
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateCamera_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_시작 : TriggerState {
            internal StateCamera_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "으아아악!!!", arg4: 2);
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetMesh(triggerIds: new []{1001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_PC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_PC : TriggerState {
            internal StateCamera_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_BossSpawn : TriggerState {
            internal StateCamera_BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Bossmove");
                context.SetNpcRotation(spawnId: 0, rotation: 180);
                context.SetConversation(type: 1, spawnId: 0, script: "응??", arg4: 2);
                context.CameraSelect(triggerId: 502, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_PC도망Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_PC도망Prepare : TriggerState {
            internal StateCamera_PC도망Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 0, rotation: 180);
                context.SetConversation(type: 1, spawnId: 0, script: "튀자!!", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CameraReset(interpolationTime: 0.1f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007}, visible: false);
            }

            public override TriggerState? Execute() {
                return new State달리기시작(context);
            }

            public override void OnExit() { }
        }

        private class State달리기시작 : TriggerState {
            internal State달리기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetLocalCamera(cameraId: 511, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PCrun");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_Bossrun");
                context.SetEventUI(arg1: 1, script: "무서운 몬스터로부터 도망치세요", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State탈출Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출Success : TriggerState {
            internal State탈출Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG\Common\ScreenMask\Eff_CameraMasking_white.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020008, portalId: 6001);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
