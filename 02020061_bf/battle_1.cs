using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020061_bf {
    public static class _battle_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "GaugeClear", value: 0);
                context.StartCombineSpawn(groupId: new []{478}, isStart: false);
                context.StartCombineSpawn(groupId: new []{479}, isStart: false);
                context.StartCombineSpawn(groupId: new []{480}, isStart: false);
                context.StartCombineSpawn(groupId: new []{481}, isStart: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 1) {
                    return new State스폰_1_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_SE : TriggerState {
            internal State스폰_1_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new []{478}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1 : TriggerState {
            internal State스폰_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__BATTLE_1__0$");
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 200) {
                    return new State스폰_2_SE(context);
                }

                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    // return new State스폰_1_추가대사(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_추가Script1 : TriggerState {
            internal State스폰_1_추가Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_nomal", duration: 5000, script: "$02020061_BF__BATTLE_1__1$");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1_추가Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_추가Script2 : TriggerState {
            internal State스폰_1_추가Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020061_BF__BATTLE_1__2$");
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 200) {
                    return new State스폰_2_SE(context);
                }

                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2_SE : TriggerState {
            internal State스폰_2_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2 : TriggerState {
            internal State스폰_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new []{479}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 400) {
                    return new State스폰_3_SE(context);
                }

                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3_SE : TriggerState {
            internal State스폰_3_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3 : TriggerState {
            internal State스폰_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new []{480}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 600) {
                    return new State스폰_4_SE(context);
                }

                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4_SE : TriggerState {
            internal State스폰_4_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4 : TriggerState {
            internal State스폰_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new []{481}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 800) {
                    return new State오브젝트Phase(context);
                }

                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트Phase : TriggerState {
            internal State오브젝트Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionCloseBossGauge();
                context.StartCombineSpawn(groupId: new []{478}, isStart: false);
                context.StartCombineSpawn(groupId: new []{479}, isStart: false);
                context.StartCombineSpawn(groupId: new []{480}, isStart: false);
                context.StartCombineSpawn(groupId: new []{481}, isStart: false);
                context.SetUserValue(triggerId: 99990001, key: "GaugeClear", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnStart") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
