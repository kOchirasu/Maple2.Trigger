namespace Maple2.Trigger._02100000_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateCheckUser10_GuildRaid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckUser10_GuildRaid : TriggerState {
            internal StateCheckUser10_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 101) >= 10) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }

                if (context.GetUserCount(boxId: 101) < 10) {
                    context.State = new StateMaxCount10_Wait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            internal StateMaxCount10_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 101) >= 10) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateMaxCount10_Wait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            internal StateMaxCount10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 904, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateShowCaption01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01 : TriggerState {
            internal StateShowCaption01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100000_BF__MAIN__0$");
                context.SetSkip(arg1: "ShowCaption01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateShowCaption01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01Skip : TriggerState {
            internal StateShowCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateShowCaption02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02 : TriggerState {
            internal StateShowCaption02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100000_BF__MAIN__1$");
                context.SetSkip(arg1: "ShowCaption02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateShowCaption02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02Skip : TriggerState {
            internal StateShowCaption02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCloseCaptionSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCloseCaptionSetting : TriggerState {
            internal StateCloseCaptionSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CloseCinematic();
                context.CameraSelect(arg1: 904, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000133, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {101}, arg2: 70000133, arg3: 1, arg4: false, arg5: true);
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetEffect(arg1: new[] {8002}, arg2: false);
                context.SetEffect(arg1: new[] {8003}, arg2: false);
                context.SetMesh(arg1: new[] {80000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {910001}, arg2: true);
                context.SetSkill(arg1: new[] {910002}, arg2: true);
                context.SetSkill(arg1: new[] {910003}, arg2: true);
                context.SetSkill(arg1: new[] {910004}, arg2: true);
                context.SetSkill(arg1: new[] {910005}, arg2: true);
                context.SetSkill(arg1: new[] {910006}, arg2: true);
                context.SetSkill(arg1: new[] {910007}, arg2: true);
                context.SetSkill(arg1: new[] {910008}, arg2: true);
                context.SetSkill(arg1: new[] {910009}, arg2: true);
                context.SetSkill(arg1: new[] {910010}, arg2: true);
                context.SetSkill(arg1: new[] {910011}, arg2: true);
                context.SetSkill(arg1: new[] {910012}, arg2: true);
                context.SetSkill(arg1: new[] {910013}, arg2: true);
                context.SetSkill(arg1: new[] {910014}, arg2: true);
                context.SetSkill(arg1: new[] {910015}, arg2: true);
                context.SetSkill(arg1: new[] {910016}, arg2: true);
                context.SetSkill(arg1: new[] {910017}, arg2: true);
                context.SetSkill(arg1: new[] {910018}, arg2: true);
                context.SetSkill(arg1: new[] {910019}, arg2: true);
                context.SetSkill(arg1: new[] {910020}, arg2: true);
                context.SetSkill(arg1: new[] {920001}, arg2: true);
                context.SetSkill(arg1: new[] {920002}, arg2: true);
                context.SetSkill(arg1: new[] {920003}, arg2: true);
                context.SetSkill(arg1: new[] {920004}, arg2: true);
                context.SetSkill(arg1: new[] {920005}, arg2: true);
                context.SetSkill(arg1: new[] {920006}, arg2: true);
                context.SetSkill(arg1: new[] {920007}, arg2: true);
                context.SetSkill(arg1: new[] {920008}, arg2: true);
                context.SetSkill(arg1: new[] {920009}, arg2: true);
                context.SetSkill(arg1: new[] {920010}, arg2: true);
                context.SetSkill(arg1: new[] {920011}, arg2: true);
                context.SetSkill(arg1: new[] {920012}, arg2: true);
                context.SetSkill(arg1: new[] {920013}, arg2: true);
                context.SetSkill(arg1: new[] {920014}, arg2: true);
                context.SetSkill(arg1: new[] {920015}, arg2: true);
                context.SetSkill(arg1: new[] {930001}, arg2: true);
                context.SetSkill(arg1: new[] {930002}, arg2: true);
                context.SetSkill(arg1: new[] {930003}, arg2: true);
                context.SetSkill(arg1: new[] {930004}, arg2: true);
                context.SetSkill(arg1: new[] {930005}, arg2: true);
                context.SetSkill(arg1: new[] {930006}, arg2: true);
                context.SetSkill(arg1: new[] {930007}, arg2: true);
                context.SetSkill(arg1: new[] {930008}, arg2: true);
                context.SetSkill(arg1: new[] {930009}, arg2: true);
                context.SetSkill(arg1: new[] {930010}, arg2: true);
                context.SetSkill(arg1: new[] {930011}, arg2: true);
                context.SetSkill(arg1: new[] {930012}, arg2: true);
                context.SetSkill(arg1: new[] {930013}, arg2: true);
                context.SetSkill(arg1: new[] {930014}, arg2: true);
                context.SetSkill(arg1: new[] {930015}, arg2: true);
                context.SetSkill(arg1: new[] {930016}, arg2: true);
                context.SetSkill(arg1: new[] {940001}, arg2: true);
                context.SetSkill(arg1: new[] {940002}, arg2: true);
                context.SetSkill(arg1: new[] {940003}, arg2: true);
                context.SetSkill(arg1: new[] {940004}, arg2: true);
                context.SetSkill(arg1: new[] {940005}, arg2: true);
                context.SetSkill(arg1: new[] {940006}, arg2: true);
                context.SetSkill(arg1: new[] {940007}, arg2: true);
                context.SetSkill(arg1: new[] {940008}, arg2: true);
                context.SetSkill(arg1: new[] {940009}, arg2: true);
                context.SetSkill(arg1: new[] {940010}, arg2: true);
                context.SetSkill(arg1: new[] {940011}, arg2: true);
                context.SetSkill(arg1: new[] {940012}, arg2: true);
                context.SetSkill(arg1: new[] {940013}, arg2: true);
                context.SetSkill(arg1: new[] {940014}, arg2: true);
                context.SetSkill(arg1: new[] {940015}, arg2: true);
                context.SetSkill(arg1: new[] {940016}, arg2: true);
                context.SetSkill(arg1: new[] {940017}, arg2: true);
                context.SetSkill(arg1: new[] {940018}, arg2: true);
                context.SetSkill(arg1: new[] {940019}, arg2: true);
                context.SetSkill(arg1: new[] {940020}, arg2: true);
                context.SetSkill(arg1: new[] {940021}, arg2: true);
                context.SetSkill(arg1: new[] {940022}, arg2: true);
                context.SetSkill(arg1: new[] {940023}, arg2: true);
                context.SetSkill(arg1: new[] {940024}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State버프_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_2 : TriggerState {
            internal State버프_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02100000_BF__MAIN__2$", arg3: 3000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new State바리케이트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바리케이트 : TriggerState {
            internal State바리케이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02100000_BF__MAIN__3$", arg3: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State닫기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State닫기 : TriggerState {
            internal State닫기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8001}, arg2: true);
                context.SetEffect(arg1: new[] {8002}, arg2: true);
                context.SetEffect(arg1: new[] {8003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }
    }
}