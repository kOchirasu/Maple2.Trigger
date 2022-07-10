namespace Maple2.Trigger._02100009_bf {
    public static class _barricade {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{80000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateCheckUser10_GuildRaid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckUser10_GuildRaid : TriggerState {
            internal StateCheckUser10_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, clearAtZero: true, display: false, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 102) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.GetUserCount(boxId: 102) < 10) {
                    return new StateMaxCount10_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            internal StateMaxCount10_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 102) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMaxCount10_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            internal StateMaxCount10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                return new StateDungeonStart(context);
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 904, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateShowCaption01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01 : TriggerState {
            internal StateShowCaption01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100009_BF__BARRICADE__0$");
                context.SetSkip(state: new StateShowCaption01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateShowCaption01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01Skip : TriggerState {
            internal StateShowCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateShowCaption02(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02 : TriggerState {
            internal StateShowCaption02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100009_BF__BARRICADE__1$");
                context.SetSkip(state: new StateShowCaption02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateShowCaption02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02Skip : TriggerState {
            internal StateShowCaption02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCloseCaptionSetting(context);
            }

            public override void OnExit() { }
        }

        private class StateCloseCaptionSetting : TriggerState {
            internal StateCloseCaptionSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CloseCinematic();
                context.CameraSelect(triggerId: 904, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001, 7002, 7003, 7004}, visible: false);
                context.SetMesh(triggerIds: new []{8000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{100000001}) || context.MonsterInCombat(spawnIds: new []{100000002})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02100009_BF__BARRICADE__2$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateBlock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock : TriggerState {
            internal StateBlock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{7001, 7002, 7003, 7004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{100000001, 100000002})) {
                    return new StateUnblock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnblock : TriggerState {
            internal StateUnblock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{7001, 7002, 7003, 7004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
