namespace Maple2.Trigger._52020035_qd {
    public static class _main30000318 {
        public class StateIdle3 : TriggerState {
            internal StateIdle3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{703}, questIds: new []{30000318}, questStates: new byte[]{2})) {
                    return new StateStartCinematic3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic3 : TriggerState {
            internal StateStartCinematic3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 8, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartCinematic3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic3_1 : TriggerState {
            internal StateStartCinematic3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
                context.DestroyMonster(spawnIds: new []{117, 118, 119, 120, 121});
                context.CreateMonster(spawnIds: new []{110}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{117}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{118}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{119}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{120}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{121}, arg2: false, arg3: 0);
                context.CameraSelectPath(pathIds: new []{4026}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State뒷이야기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기 : TriggerState {
            internal State뒷이야기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 8, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003754, script: "크크큭... 착한 연기 잘 하는군. 라딘.", duration: 3000);
                context.SetSceneSkip(state: new State끝(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State뒷이야기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기_02 : TriggerState {
            internal State뒷이야기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4028}, returnView: false);
                context.AddCinematicTalk(npcId: 11003753, script: "...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State뒷이야기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기01 : TriggerState {
            internal State뒷이야기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4030}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 119, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003756, script: "훗. 생각보다 잘 넘어간 것 같군요.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003759, script: "쳇, 복잡하게 만들지 말고 그냥 죽어버리면 되잖아?", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State뒷이야기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기02 : TriggerState {
            internal State뒷이야기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4026}, returnView: false);
                context.AddCinematicTalk(npcId: 11003754, script: "하렌. 그럼 우리도 다음 작전을 이야기 해 볼까.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State뒷이야기02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기02_1 : TriggerState {
            internal State뒷이야기02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4031}, returnView: false);
                context.MoveNpc(spawnId: 119, patrolName: "MS2PatrolData_3008");
                context.AddCinematicTalk(npcId: 11003756, script: "...후훗.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 9, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 9, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 02020012, portalId: 1);
                context.DestroyMonster(spawnIds: new []{111, 112, 113, 114, 115});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
