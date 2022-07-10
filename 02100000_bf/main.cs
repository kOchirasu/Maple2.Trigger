namespace Maple2.Trigger._02100000_bf {
    public static class _main {
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
                if (context.GetUserCount(boxId: 101) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.GetUserCount(boxId: 101) < 10) {
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
                if (context.GetUserCount(boxId: 101) >= 10) {
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
                context.SetCinematicIntro(text: "$02100000_BF__MAIN__0$");
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
                context.SetCinematicIntro(text: "$02100000_BF__MAIN__1$");
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
                context.AddBuff(boxIds: new []{101}, skillId: 70000133, level: 1, arg4: false, arg5: false);
                context.AddBuff(boxIds: new []{101}, skillId: 70000133, level: 1, arg4: false, arg5: true);
                context.SetEffect(triggerIds: new []{8001, 8002, 8003}, visible: false);
                context.SetMesh(triggerIds: new []{80000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{910001, 910002, 910003, 910004, 910005, 910006, 910007, 910008, 910009, 910010, 910011, 910012, 910013, 910014, 910015, 910016, 910017, 910018, 910019, 910020, 920001, 920002, 920003, 920004, 920005, 920006, 920007, 920008, 920009, 920010, 920011, 920012, 920013, 920014, 920015, 930001, 930002, 930003, 930004, 930005, 930006, 930007, 930008, 930009, 930010, 930011, 930012, 930013, 930014, 930015, 930016, 940001, 940002, 940003, 940004, 940005, 940006, 940007, 940008, 940009, 940010, 940011, 940012, 940013, 940014, 940015, 940016, 940017, 940018, 940019, 940020, 940021, 940022, 940023, 940024}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBuff_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_2 : TriggerState {
            internal StateBuff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02100000_BF__MAIN__2$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new State바리케이트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바리케이트 : TriggerState {
            internal State바리케이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02100000_BF__MAIN__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State닫기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State닫기 : TriggerState {
            internal State닫기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{80000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8001, 8002, 8003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
