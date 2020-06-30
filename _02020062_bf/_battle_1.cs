using System;

namespace Maple2.Trigger._02020062_bf {
    public static class _battle_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990001, key: "GaugeClear", value: 0);
                context.StartCombineSpawn(groupId: new int[] {490}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {491}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {492}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {493}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {495}, isStart: "false");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 1)) {
                    context.State = new State스폰_1_SE(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_1_SE : TriggerState {
            internal State스폰_1_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new int[] {490}, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State스폰_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_1 : TriggerState {
            internal State스폰_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11001813, illust: "Turka_normal", duration: 5000,
                    script: "$02020062_BF__BATTLE_1__0$");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State스폰_1_추가대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_1_추가대사1 : TriggerState {
            internal State스폰_1_추가대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003533, illust: "Bliche_normal", duration: 5000,
                    script: "$02020062_BF__BATTLE_1__1$");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State스폰_1_추가대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_1_추가대사2 : TriggerState {
            internal State스폰_1_추가대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02020062_BF__BATTLE_1__2$");
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 120)) {
                    context.State = new State스폰_2_SE(context);
                    return;
                }

                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_2_SE : TriggerState {
            internal State스폰_2_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State스폰_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_2 : TriggerState {
            internal State스폰_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new int[] {491}, isStart: "true");
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 300)) {
                    context.State = new State스폰_3_SE(context);
                    return;
                }

                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_3_SE : TriggerState {
            internal State스폰_3_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State스폰_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_3 : TriggerState {
            internal State스폰_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new int[] {492}, isStart: "true");
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 450)) {
                    context.State = new State스폰_4_SE(context);
                    return;
                }

                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_4_SE : TriggerState {
            internal State스폰_4_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State스폰_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_4 : TriggerState {
            internal State스폰_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new int[] {493}, isStart: "true");
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 600)) {
                    context.State = new State스폰_5_SE(context);
                    return;
                }

                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_5_SE : TriggerState {
            internal State스폰_5_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State스폰_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰_5 : TriggerState {
            internal State스폰_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new int[] {495}, isStart: "true");
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 750)) {
                    context.State = new State오브젝트페이즈(context);
                    return;
                }

                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트페이즈 : TriggerState {
            internal State오브젝트페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "CloseBossGauge");
                context.StartCombineSpawn(groupId: new int[] {490}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {491}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {492}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {493}, isStart: "false");
                context.StartCombineSpawn(groupId: new int[] {495}, isStart: "false");
                context.SetUserValue(triggerID: 99990001, key: "GaugeClear", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "SpawnStart", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}