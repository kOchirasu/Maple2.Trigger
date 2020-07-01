namespace Maple2.Trigger._82000003_survival {
    public static class _17_noticeextraevent {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "NoticeExtraEvent", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "NoticeExtraEvent") == 1) {
                    context.State = new StateNoticeExtraEvent01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNoticeExtraEvent01 : TriggerState {
            internal StateNoticeExtraEvent01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28200000, textId: 28200000, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_Mokum_Popup_UI_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNoticeExtraEvent02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNoticeExtraEvent02 : TriggerState {
            internal StateNoticeExtraEvent02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Mokum_Completion_01");
                context.SideNpcTalk(npcId: 21001019, type: "talkbottom", illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__17_NoticeExtraEvent__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNoticeExtraEvent03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNoticeExtraEvent03 : TriggerState {
            internal StateNoticeExtraEvent03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28200001, textId: 28200001, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_Mokum_Popup_UI_01");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}