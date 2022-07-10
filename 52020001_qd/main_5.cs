namespace Maple2.Trigger._52020001_qd {
    public static class _main_5 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{4})) {
                    return new State기다림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기다림 : TriggerState {
            internal State기다림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionOpenBossGauge(maxGaugePoint: 300, title: "출력 에너지");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State체력조건_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력조건_1 : TriggerState {
            internal State체력조건_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 150) {
                    return new State알림_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림_1 : TriggerState {
            internal State알림_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "에너지가 50%충전 되었습니다.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State체력조건_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{6000041, 6000042}, arg2: false);
                context.AddBuff(boxIds: new []{6000041}, skillId: 49286001, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{6000042}, skillId: 49286001, level: 1, arg4: true);
            }
        }

        private class State체력조건_2 : TriggerState {
            internal State체력조건_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 300) {
                    return new State알림_5(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(type: "trigger", code: "EscapeToKritias");
            }
        }

        private class State알림_5 : TriggerState {
            internal State알림_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "에너지가 100%충전 되었습니다.", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State알림_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림_6 : TriggerState {
            internal State알림_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "곧 최대 출력으로 돌진 합니다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막_Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic : TriggerState {
            internal State마지막_Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{2000009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State캐릭터숨기기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State캐릭터숨기기 : TriggerState {
            internal State캐릭터숨기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.CreateMonster(spawnIds: new []{7002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막_Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막_Cinematic_2 : TriggerState {
            internal State마지막_Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAICinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAICinematic : TriggerState {
            internal StateAICinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 1);
                context.CameraSelectPath(pathIds: new []{2000013}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAICinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAICinematic_2 : TriggerState {
            internal StateAICinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 0, script: "준비완료! 크리티아스로 돌진!", arg4: 3, arg5: 0);
                context.SetAiExtraData(key: "wing", value: 1, boxId: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "wing", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State끝_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝_2 : TriggerState {
            internal State끝_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020001, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
